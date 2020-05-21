using System;
using System.Linq;
using System.Collections.Generic;
using DublinBikeLocation.Models;
using DublinBikeLocation.Service;
using Xamarin.Forms;

namespace DublinBikeLocation.View
{
    public partial class NearbyPage : ContentPage
    {
        Station mock => DependencyService.Get<Station>();
        public NearbyPage()
        {
            InitializeComponent();
            GetData();
        }
        public async void GetData()
        {
            List<StationModel> newStation = new List<StationModel>();

            newStation = await mock.GetStations();
            List<StationModel> SortedStations = newStation.OrderBy(o => o.distance).ToList();
            myStations.ItemsSource = SortedStations;

        }

        private void myStations_SelectionChanged(System.Object sender, SelectionChangedEventArgs e)
        {
            StationModel myValue = e.CurrentSelection.FirstOrDefault() as StationModel;
            App.Current.MainPage.Navigation.PushModalAsync(new MapPage(myValue));
        }
        async void Back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
