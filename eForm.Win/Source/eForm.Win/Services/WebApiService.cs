using eForm.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace eForm.Win.Services
{
    public class WebApiService 
    {
        string _uri = "http://localhost:1863/api/product";

        public WebApiService()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "eForm");

            if (!Directory.Exists(userFilePath))
                Directory.CreateDirectory(userFilePath);

            string webApi = Path.Combine(userFilePath, "WebApi.txt");

            if (!File.Exists(webApi))
                File.WriteAllText(webApi, @"http://localhost:2022/api/");

            _uri = File.ReadAllText(webApi); 
        }

        public List<Application> GetAllApplications()
        {
            List<Application> applications = null;
            using (var client = new System.Net.Http.HttpClient())
            {
                using (var response = client.GetAsync(_uri + "Application").Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var applicationJsonString = response.Content.ReadAsStringAsync().Result;//<IEnumerable<Application>>().Result;
                         applications = JsonConvert.DeserializeObject<Data.Application[]>(applicationJsonString).ToList();

                    }
                }
            }
            return applications;
        }

        public  void AddApplication(Application a)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(a);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                string uri = string.Format("{0}{1}", _uri, "Application");
                 HttpResponseMessage response =  client.PostAsync(uri, content).Result;
                response.EnsureSuccessStatusCode();

                string responseBody = response.Content.ReadAsStringAsync().Result;

            }

            //using (var client = new System.Net.Http.HttpClient())
            //{
            //    var serializedProduct = JsonConvert.SerializeObject(a);
            //    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
            //    string uri = string.Format("{0}{1}{2}", _uri, "Application/", "Post");
            //    var result = client.PostAsync(uri, content);
            //}

            System.Windows.Forms.MessageBox.Show(GetAllApplications().Count.ToString()) ;
        }
    }
}
