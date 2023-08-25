using System;
using WIRVINGJIMENEZEFP6232App.Services;
using WIRVINGJIMENEZEFP6232App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WIRVINGJIMENEZEFP6232App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new BienvenidaPage());
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
