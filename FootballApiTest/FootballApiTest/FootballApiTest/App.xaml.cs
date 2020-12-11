using FootballApiTest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FootballApiTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TeamPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
