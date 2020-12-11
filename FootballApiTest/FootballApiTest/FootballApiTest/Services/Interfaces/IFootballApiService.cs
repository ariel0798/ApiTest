using FootballApiTest.Models;
using System.Threading.Tasks;

namespace FootballApiTest.Services.Interfaces
{
    public interface IFootballApiService
    {
        Task<Teams> GetTeamsAsync();
    }
}
