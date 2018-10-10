using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WhatsTheScoop
{
    public class ApiHandler
    {
        //setup 1 Http Client for application lifetime
        public static HttpClient ApiClient { get; set; }

        public static async void InitializeClientAsync()
        {
            //Makes HTTP POST web request
            ApiClient = new HttpClient();

            var _requestdata = new Dictionary<string, string>
            {
                { "body1", "firstbody" },
                { "body2", "secondbody"}
            };

            var content = new FormUrlEncodedContent(_requestdata);

            var response = await ApiClient.PostAsJsonAsync("localhost:8080/index.html", content);

            var responseString = await response.Content.ReadAsStringAsync();



            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
