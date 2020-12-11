using ApiTest.Models;
using ApiTest.Services;
using ApiTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ApiTest.ViewModels
{
    public class TeamViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Team> TeamList { get; set; }
        public IFootballApiService footballApiService = new FootballApiService();

        public ICommand TestCommand => new Command(async () => 
        {
            var teams = await footballApiService.GetTeamsAsync();
            int a = 0;
            
        });


    }
}
