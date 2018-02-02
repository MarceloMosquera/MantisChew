using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    public class WorkLog
    {
        public static HttpResponseMessage Crear(string key, decimal hours)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd")+ "T12:00:00.000-0300";
            string timeSpentSeconds = (hours * 60 * 60).ToString();

            string url = Properties.Settings.Default.JiraURL + "/rest/api/2/issue/" + key + "/worklog";
            var rawContent = "{ \"comment\": \"Creado desde MantisChew\",\"started\": \"" + date + "\",\"timeSpentSeconds\": \"" + timeSpentSeconds +"\" }";
            var client = new HttpClient();
            var content = new StringContent(rawContent, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", GetBasicAuth());

            var task = client.PostAsync(url, content); task.Wait();
            return task.Result;
        }


        private static string GetBasicAuth()
        {
            string encodedToken = Base64Encode(Properties.Settings.Default.JiraUser + ":" + Properties.Settings.Default.JiraPass);
            return "Basic " + encodedToken;
        }
        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}
