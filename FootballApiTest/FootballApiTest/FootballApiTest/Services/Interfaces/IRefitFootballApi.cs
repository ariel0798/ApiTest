using System.Threading.Tasks;
using FootballApiTest.Models;
using Refit;

namespace FootballApiTest.Services.Interfaces
{
    [Headers("x-rapidapi-key: 0b61792320msh5d5a0c269f313c6p189d9bjsn72482e737528", "x-rapidapi-host: api-football-v1.p.rapidapi.com")]
    public interface IRefitFootballApi
    {
        [Get("/v2/teams/team/{id}")]
        Task<Teams> GetTeamById(int id);
    }
}
