using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExperimentalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartOrPreferencesPage : ContentPage
    {
        public StartOrPreferencesPage()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new GuessingGamePage());
        }

        private void GoToPreferences(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new Preferences());
        }
    }
}