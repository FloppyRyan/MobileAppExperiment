using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExperimentalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinGame : ContentPage
    {
        public WinGame()
        {
            InitializeComponent();
        }

        public WinGame(int numberOfTriesTaken)
        {
            InitializeComponent();
            if (numberOfTriesTaken <= 0)
            {
                numOfTries.Text = "You somehow got 0 tries. Cheater!";
            }
            else if (numberOfTriesTaken == 1)
            {
                numOfTries.Text = $"It took you {numberOfTriesTaken.ToString()} try to correctly guess the number";
            }
            else
            {
                numOfTries.Text = $"It took you {numberOfTriesTaken.ToString()} tries to correctly guess the number";
            }
        }

        private void ReturnToMain(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new MainPage());
        }
    }
}