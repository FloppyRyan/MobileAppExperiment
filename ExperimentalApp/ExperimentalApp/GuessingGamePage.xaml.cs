using System;

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
        private int guess;
        private int actualNum;

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
            actualNum = new Random(DateTime.Now.Second).Next(lowestNumber, highestNumber);
        }

        private void Guess(object sender, EventArgs e)
        {
            int triesInt = Int32.Parse(RemainingTriesEntry.Text);
            triesInt--;
            RemainingTriesEntry.Text = triesInt.ToString();
            HighestNumberEntry.Text = highestNumber.ToString();
            LowestNumberEntry.Text = lowestNumber.ToString();

            if (!Int32.TryParse(GuessEntry.Text, out guess))
            {
                return;
            }

            if (guess == actualNum)
            {
                Navigation.PopAsync();
                Navigation.PushAsync(new WinGame(numberOfTries - triesInt));
            }
            else if (guess < actualNum)
            {
                Feedback.TextColor = Color.Red;
                Feedback.Text = "Too low";
            }
            else if (guess > actualNum)
            {
                Feedback.TextColor = Color.Red;
                Feedback.Text = "Too high";
            }
        }
    }
}