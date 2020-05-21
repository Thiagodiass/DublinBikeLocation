using System;
using System.Collections.Generic;
using DublinBikeLocation.Models;
using DublinBikeLocation.Service;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Maps;
using Position = Xamarin.Forms.Maps.Position;

namespace DublinBikeLocation.View
{
    public partial class AllStationsPage : ContentPage
    {
        Station mock => DependencyService.Get<Station>();
        private double lat = 53.349013;
        private double lng = -6.260311;
        public AllStationsPage()
        {
            InitializeComponent();
            GetData();
           
        }

        public async void GetData()
        {
            List<StationModel> newStation = new List<StationModel>();
            StationModel myValue = new StationModel();
            newStation = await mock.GetStations();
            Position position = new Position(lat, lng);
            MapSpan mapSpan = new MapSpan(position, 0.1, 0.1);
            Map MyMap = new Map(mapSpan);
            foreach (var stations in newStation)
            {
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(stations.lat, stations.lng),

                    Label = stations.StationName,
                    Address = stations.Address
                };
                MyMap.Pins.Add(pin);
                container.Children.Add(MyMap);
            }
        }
        async void Back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}
