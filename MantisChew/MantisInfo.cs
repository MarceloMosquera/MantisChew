using System;
using System.Collections.Generic;
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

        public MantisInfo()
        {
            baseAddress = new Uri(Properties.Settings.Default.MantisUrlBase);
            cookieContainer = new CookieContainer();
            handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            client = new HttpClient(handler) { BaseAddress = baseAddress };

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
        }

        public void Download(dsDatos.MantisEstadoRow mantisEstadoRow)
        {
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
                var trVersion = trs[12];
                var trFecha = trs[23];


                var estado = Regex.Replace(trEstado.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");
                var proyecto = Regex.Replace(trProyecto.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");
                var version = Regex.Replace(trVersion.Descendants("td").ToList()[3].InnerText, @"\t|\n|\r", "");
                var fecha = Regex.Replace(trFecha.Descendants("td").ToList()[1].InnerText, @"\t|\n|\r", "");


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

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                newMantisEstadoRow.Estado = "";
                newMantisEstadoRow.Proyecto = "";
                newMantisEstadoRow.Version = "";
                newMantisEstadoRow.Fecha = "";
                newMantisEstadoRow.HrsTotal = "0";
            }
        }

        public void Dispose()
        {
            client.Dispose();
            handler.Dispose();
        }

    }
}
