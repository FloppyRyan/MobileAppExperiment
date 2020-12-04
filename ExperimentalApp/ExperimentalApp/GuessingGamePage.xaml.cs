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
    public partial class GuessingGamePage : ContentPage
    {
        private const int highestNumber = 100;
        private const int lowestNumber = 0;
        private int numberOfTries = 100;
        private const string highestlabel = "Highest Number";
        private const string lowestlabel = "Lowest Number";
        private const string trieslabel = "Number of Tries Remaining";
        private const string enternumberlabel = "Enter a Number";

        public GuessingGamePage()
        {
            InitializeComponent();
            HighestNumberLabel.Text = highestlabel;
            HighestNumberEntry.Text = highestNumber.ToString();
            HighestNumberLabel.FontSize = 15;
            HighestNumberLabel.FontAttributes = FontAttributes.Bold;
            LowestNumberLabel.Text = lowestlabel;
            LowestNumberEntry.Text = lowestNumber.ToString();
            RemainingTriesLabel.Text = trieslabel;
            RemainingTriesEntry.Text = numberOfTries.ToString();
            EnterNumberLabel.Text = enternumberlabel;
        }

        async void ReturnToMain(object sender, EventArgs e)
        {
            _ = await Navigation.PopAsync();
        }

        Binding highestNumberBinding = new Binding();

        private void Guess(object sender, EventArgs e)
        {
            string tries = RemainingTriesEntry.Text;
            int triesInt = Int32.Parse(tries);
            triesInt--;
            RemainingTriesEntry.Text = triesInt.ToString();
            HighestNumberEntry.Text = highestNumber.ToString();
            LowestNumberEntry.Text = lowestNumber.ToString();
        }

        private void EndGame()
        {

        }
    }
}