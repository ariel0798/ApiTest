using ApiTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamsPage : ContentPage
    {
        public TeamsPage()
        {
            InitializeComponent();
            this.BindingContext = new TeamViewModel();
        }
    }
}