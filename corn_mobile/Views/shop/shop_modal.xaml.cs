using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace corn_mobile.Views.shop
{
    public partial class shop_modal : PopupPage
    {
        /*public shop_modal()
        {
            InitializeComponent();

        }*/

        [Obsolete]
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new shop_modal());
        }
    }
}
