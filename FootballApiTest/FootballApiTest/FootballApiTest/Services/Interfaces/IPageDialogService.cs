using System.Threading.Tasks;

namespace FootballApiTest.Services.Interfaces
{
    public interface IPageDialogService
    {
        Task DisplayAlert(string title, string message, string okText = "Ok");
    }
}
