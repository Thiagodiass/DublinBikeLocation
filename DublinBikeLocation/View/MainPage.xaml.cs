using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DublinBikeLocation.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void nearby_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NearbyPage());
        }

        async void allStations_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new AllStationsPage());
        }
    }
}
