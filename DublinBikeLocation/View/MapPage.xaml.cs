using System;
using System.Collections.Generic;
using DublinBikeLocation.Models;
using DublinBikeLocation.Service;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DublinBikeLocation.View
{
    public partial class MapPage : ContentPage
    {
        Station mock => DependencyService.Get<Station>();
        StationModel myValue = new StationModel();
        public MapPage(StationModel station)
        {
            InitializeComponent();

            myValue = station;
            Position position = new Position(myValue.lat, myValue.lng);
            MapSpan mapSpan = new MapSpan(position, 0.1, 0.1);
            Map MyMap = new Map(mapSpan);

            Pin pin = new Pin
            {
                Position = new Position(myValue.lat, myValue.lng),
                Label = myValue.StationName,
                Address = myValue.Address
            };
            MyMap.IsShowingUser = true;

            MyMap.Pins.Add(pin);
            container.Children.Add(MyMap);
        }
        async void Back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
