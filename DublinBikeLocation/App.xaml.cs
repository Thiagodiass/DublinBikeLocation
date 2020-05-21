using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DublinBikeLocation.View;
using DublinBikeLocation.Service;

namespace DublinBikeLocation
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<Station>();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
