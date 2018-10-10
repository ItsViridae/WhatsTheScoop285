using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WhatsTheScoop.Data;
using WhatsTheScoop;

namespace WhatsTheScoop.Processors
{
    public class AppProcessor
    {
        public static async Task<DBProcessorModel> loadRequest()
        {
            string url = "";

            using (HttpResponseMessage response = await ApiHandler.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DBProcessorModel request = await response.Content.ReadAsAsync<DBProcessorModel>();

                    return request;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
