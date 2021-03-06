﻿using System;
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

        //async void StartGuessingGame(object sender, EventArgs e) => await Navigation.PushAsync(new GuessingGamePage());

        void StartGuessingGame(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new GuessingGamePage());
        }
    }
}
