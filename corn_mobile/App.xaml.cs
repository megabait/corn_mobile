using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using corn_mobile.Services;
using corn_mobile.Views;
using corn_mobile.Views.shop;

namespace corn_mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new menu_shop();
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
