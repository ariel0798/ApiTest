using ApiTest.Models;
using System.Threading.Tasks;

namespace ApiTest.Services.Interfaces
{
    public interface IFootballApiService
    {
        Task<Teams> GetTeamsAsync();
    }
}
