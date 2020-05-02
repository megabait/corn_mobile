using corn_mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace corn_mobile.Views.shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tab_shop : ContentPage
    {
        public tab_shop()
        {
            InitializeComponent();
            BindingContext = new shopViewModel() { Navigation = this.Navigation };
        }
    }
}