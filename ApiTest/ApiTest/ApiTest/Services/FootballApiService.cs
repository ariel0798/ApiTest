using ApiTest.Services.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ApiTest.Models;

namespace ApiTest.Services
{
    public class FootballApiService : IFootballApiService
    {
        public async Task<Teams> GetTeamsAsync()
        {
            Teams teams = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v2/teams/team/33"),
                Headers =
                    {
                        { "x-rapidapi-key", "fbc296b9e3msh4fc9f5a872072f6p10717fjsn2ce12df2a2ea" },
                        { "x-rapidapi-host", "api-football-v1.p.rapidapi.com" },
                    },
            };

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                teams = JsonConvert.DeserializeObject<Teams>(await response.Content.ReadAsStringAsync());
            }

            return teams;
        }
    }
}
