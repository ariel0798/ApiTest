using FootballApiTest.Models;
using FootballApiTest.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FootballApiTest.Services
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
                        { "x-rapidapi-key", "0b61792320msh5d5a0c269f313c6p189d9bjsn72482e737528" },
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
