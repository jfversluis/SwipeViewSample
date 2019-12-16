using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwipeViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Favorite_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Favorite", "Xamarin.Forms is my favorite too!", "<3");
        }

        void Delete_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "Are you sure you want to delete Xamarin.Forms?", "No");
        }
    }
}