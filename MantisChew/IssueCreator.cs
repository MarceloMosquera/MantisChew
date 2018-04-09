using Jira.SDK.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MantisChew
{
    public class IssueCreator
    {
        public static CreateResponse Crear(IssueToCreate issueToCreate)
        {

            string url = Properties.Settings.Default.JiraUrlBase + "/rest/api/2/issue/";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", GetBasicAuth());

            var taskCreate = client.PostAsync(url, GetCreateContent(issueToCreate)); taskCreate.Wait();
            var result = taskCreate.Result;
            if (result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var taskReadResponse = result.Content.ReadAsStringAsync(); taskReadResponse.Wait();
                var respJson = taskReadResponse.Result;
                var response = JsonConvert.DeserializeObject<CreateResponse>(respJson);

                var taskUpdate = client.PutAsync(response.self, GetUpdateContent(issueToCreate)); taskUpdate.Wait();
                result = taskUpdate.Result;

                if (result.StatusCode == System.Net.HttpStatusCode.NoContent) return response;
            }
            throw new ApplicationException(result.ReasonPhrase);
        }

        private static StringContent GetCreateContent(IssueToCreate issueToCreate)
        {
            var issue = new
            {
                fields = new
                {
                    project = new { key = issueToCreate.Project },
                    summary = issueToCreate.Summary,
                    description = issueToCreate.Description,
                    issuetype = new { name = issueToCreate.IssueType },
                    customfield_13900 = issueToCreate.NroExterno,
                    labels = new[] { issueToCreate.Label }
                }

            };


            string rawContent = JsonConvert.SerializeObject(issue);

            return new StringContent(rawContent, Encoding.UTF8, "application/json");
        }

        private static StringContent GetUpdateContent(IssueToCreate issueToCreate)
        {
            var issue = new
            {
                update = new
                {
                    components = new[] { new { add = new { name = issueToCreate.Component } } },
                    comment = new[] { new { add = new { body = issueToCreate.Comment } } }
                }
            };


            string rawContent = JsonConvert.SerializeObject(issue);

            return new StringContent(rawContent, Encoding.UTF8, "application/json");
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

    public class IssueToCreate
    {
        public string NroExterno { get; set; }
        public string Project { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string IssueType { get; set; }
        public string Component { get; set; }
        public string Comment { get; set; }
        public string Label { get; set; }

    }

    public class CreateResponse
    {
        public string id { get; set; }
        public string key { get; set; }
        public string self { get; set; }

    }

}