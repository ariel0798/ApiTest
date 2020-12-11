using FootballApiTest.Models;
using FootballApiTest.Services;
using FootballApiTest.Services.Interfaces;
using Refit;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FootballApiTest.ViewModels
{
    public class TeamViewModel : INotifyPropertyChanged
    {
        readonly string url = "https://api-football-v1.p.rapidapi.com";
        readonly IPageDialogService pageDialogService;
        public TeamViewModel(IPageDialogService pageDialogService)
        {
            this.pageDialogService = pageDialogService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Team Team { get; set; }
        public IFootballApiService footballApiService = new FootballApiService();

        

        public ICommand GetTeamDataCommand => new Command(async () =>
        {
            var current = Connectivity.NetworkAccess;
            
            if(current == NetworkAccess.Internet)
            {
                var serviceApi = RestService.For<IRefitFootballApi>(url);

                var teams = await serviceApi.GetTeamById(33);

                if (teams != null)
                {
                    this.Team = teams.api.teams[0];
                }
                else
                {
                    await pageDialogService.DisplayAlert("Error", "An error occurred connecting to the API");
                }
            }
            else
            {
                await pageDialogService.DisplayAlert("No Internet", "Please check your internet connection");
            }

        });


    }
}
