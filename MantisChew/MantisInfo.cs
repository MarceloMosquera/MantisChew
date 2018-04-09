using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MantisChew
{
    public class MantisInfo :IDisposable    
    {

        private Uri baseAddress; 
        private CookieContainer cookieContainer = new CookieContainer();

        private HttpClientHandler handler;
        private HttpClient client;

        public bool LoginOK { get; set; }

        public MantisInfo()
        {
            baseAddress = new Uri(Properties.Settings.Default.MantisUrlBase);
            cookieContainer = new CookieContainer();
            handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            client = new HttpClient(handler) { BaseAddress = baseAddress };
            client.Timeout = new TimeSpan(0, 5, 0);

            DoLogin();
        }

        private void DoLogin()
        {
            var values = new Dictionary<string, string>
                {
                    { "username", Properties.Settings.Default.MantisUser },
                    { "password", Properties.Settings.Default.MantisPass },
                    { "secure_session", "on" }//,
                };
            var content = new FormUrlEncodedContent(values);

            HttpResponseMessage response = client.PostAsync(Properties.Settings.Default.MantisUrlLogin, content).Result;
            LoginOK = response.StatusCode == HttpStatusCode.OK && cookieContainer.GetCookies(baseAddress).Count > 2;
       
        }

        public void Download(dsDatos.MantisEstadoRow mantisEstadoRow)
        {
            if (!LoginOK) return;
            var str = GetMantisHtml(mantisEstadoRow.Nro.ToString()).Result;
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(str);
            getFromHeader(doc, mantisEstadoRow);
        }

        private async Task<string> GetMantisHtml(string idMantis)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, Properties.Settings.Default.MantisUrlView + idMantis);
            var result = client.SendAsync(message).Result;
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsStringAsync();
        }

        private static void getFromHeader(HtmlAgilityPack.HtmlDocument doc, dsDatos.MantisEstadoRow newMantisEstadoRow)
        {
            try
            {
                var tHead = doc.DocumentNode.Descendants("table").ToList()[2];
                var trs = tHead.Descendants("tr").ToList();
                var trEstado = trs[9];
                var trProyecto = trs[4];
                var trTipo = trs[4];
                var trVersion = trs[12];
                var trFecha = trs[23];
                var trResumen = trs[14];


                var estado = Regex.Replace(trEstado.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");
                var proyecto = Regex.Replace(trProyecto.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");
                var tipo = Regex.Replace(trTipo.Descendants("td").ToList()[2].InnerText, @"\t|\n|\r", "");
                var version = Regex.Replace(trVersion.Descendants("td").ToList()[3].InnerText, @"\t|\n|\r", "");
                var fecha = Regex.Replace(trFecha.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");
                var resumen = Regex.Replace(trResumen.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");


                var timeRecord = doc.DocumentNode.Descendants("div")
                    .Where(x => x.Attributes["id"]?.Value == "timerecord_open")
                    .FirstOrDefault()
                    .Descendants("td")
                    .Select(x => x?.InnerText)
                    .ToList();

                var tdHoras = timeRecord[timeRecord.Count - 5];
                var horas = Regex.Replace(tdHoras, @"\t|\n|\r|:00", "");

                newMantisEstadoRow.Estado = estado;
                newMantisEstadoRow.Proyecto = proyecto;
                newMantisEstadoRow.Version = version;
                newMantisEstadoRow.Fecha = fecha;
                newMantisEstadoRow.HrsTotal = horas;
                newMantisEstadoRow.Tipo = tipo;
                newMantisEstadoRow.Resumen = resumen;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                newMantisEstadoRow.Estado = "";
                newMantisEstadoRow.Proyecto = "";
                newMantisEstadoRow.Version = "";
                newMantisEstadoRow.Fecha = "";
                newMantisEstadoRow.HrsTotal = "0";
                newMantisEstadoRow.Tipo = "";
                newMantisEstadoRow.Resumen = "";

            }
        }

        public void Dispose()
        {
            client.Dispose();
            handler.Dispose();
        }


        public string DownloadTimeReport2(DateTime fromDate, DateTime toDate)
        {
            string responseString = string.Empty;
            if (!LoginOK) return null;
            //using (var client = new HttpClient())
            //{
            baseAddress = new Uri(Properties.Settings.Default.MantisUrlBase);
            cookieContainer.Add(baseAddress, new Cookie("MANTIS_PROJECT_COOKIE", "0"));
            cookieContainer.Add(baseAddress, new Cookie("MANTIS_collapse_settings", "|filter"));
            cookieContainer.Add(baseAddress, new Cookie("MANTIS_VIEW_ALL_COOKIE", "5485"));


            var message = new HttpRequestMessage(HttpMethod.Get, "/mantis/it/excel_xml_export_time.php?project=0&from=2018-2-5&to=2018-3-2");
                message.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                message.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
                message.Headers.Add("Accept-Language", "es-419,es;q=0.8,en;q=0.6,fr;q=0.4,it;q=0.2,pt;q=0.2,pl;q=0.2,nl;q=0.2");
                message.Headers.Add("Connection", "keep-alive");
            message.Headers.Add("Upgrade-Insecure-Requests", "1");
            message.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");

            var response = client.SendAsync(message).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;

                    // by calling .Result you are synchronously reading the result
                    responseString = responseContent.ReadAsStringAsync().Result;

                    Console.WriteLine(responseString);
                }
            //}
            return responseString;
        }

        public Stream DownloadTimeReport(DateTime fromDate, DateTime toDate)
        {
            if (!LoginOK) return null;
            var text =  GetMantisXls(fromDate.ToString("yyyy-MM-dd"), fromDate.ToString("yyyy-MM-dd")).Result;

            return GenerateStreamFromString(text);
        }
        private async Task<string> GetMantisXls(string fromDate, string toDate)
        {
            //var values = new Dictionary<string, string>
            //    {
            //        { "project", "0" },
            //        { "from", fromDate },
            //        { "to", toDate }//,
            //    };
            //var content = new FormUrlEncodedContent(values);
            try
            {
                string responseContent = "";
                var message = new HttpRequestMessage(HttpMethod.Get, "/mantis/it/excel_xml_export_time.php?project=0&from=2018-2-5&to=2018-3-2");
                message.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                message.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
                message.Headers.Add("Accept-Language", "es-419,es;q=0.8,en;q=0.6,fr;q=0.4,it;q=0.2,pt;q=0.2,pl;q=0.2,nl;q=0.2");
                //var response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                var response = client.SendAsync(message).Result;
                //using (HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                //{
                //    responseContent = response.Content.ReadAsStringAsync().Result;
                //}
                //return responseContent;

                //using (HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                //{
                //    responseContent = response.Content.ReadAsStringAsync().Result;
                //}

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {

                throw;
            }

        }
        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
