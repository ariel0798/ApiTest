using ApiTest.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Services
{
    public class FootballApiService : IFootballApiService
    {
        public async Task GetSomethingAsync(string something)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("");

            if(response.IsSuccessStatusCode)
            {
                //var something = JsonConvert.DeserializeObject<>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
