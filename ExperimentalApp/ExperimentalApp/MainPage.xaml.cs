using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExperimentalApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        async void GoToPage2(object sender, EventArgs e) => await Navigation.PushAsync(new Page2());

        async void StartGuessingGame(object sender, EventArgs e) => await Navigation.PushAsync(new GuessingGamePage());
    }
}
