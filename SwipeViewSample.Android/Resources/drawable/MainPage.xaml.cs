using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SwipeViewSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Favorite_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Xamarin.Forms is my favorite too! <3", "Favorite", "Woohoo!");
        }

        void Delete_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Are you sure you want to delete Xamarin.Forms?", "Delete", "No");
        }
    }
}