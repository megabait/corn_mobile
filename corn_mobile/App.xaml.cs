using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using corn_mobile.Services;
using corn_mobile.Views;

namespace corn_mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
