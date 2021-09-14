using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EventyApp.Views;

namespace EventyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProfilePageView();
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
