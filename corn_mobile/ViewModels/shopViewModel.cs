using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using corn_mobile.Views.shop;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace corn_mobile.ViewModels
{
    public class shopViewModel : INotifyPropertyChanged
    {
        public class newApiProduct
        {
            public int id { get; set; }
            public string name { get; set; }
            public int amount { get; set; }
            public string img { get; set; }
            public int count { get; set; } //0
            public int type { get; set; } //0 Продукты, 1 Рецепты 
            public bool seasoning { get; set; } // Яляеться приправой или нет
        }
        List<newApiProduct> product = new List<newApiProduct>
        {
            new newApiProduct { name = "Кукуруза", amount = 500, type = 1, img = "https://arctouch.com/wp-content/uploads/2017/11/xamarin-forms-capable-hero.jpg" },
            new newApiProduct { name = "Кукуруза2", amount = 500, type = 1, img = "https://arctouch.com/wp-content/uploads/2017/11/xamarin-forms-capable-hero.jpg" },
            new newApiProduct { name = "Кукуруза3", amount = 500, type = 0, img = "https://arctouch.com/wp-content/uploads/2017/11/xamarin-forms-capable-hero.jpg" }
        };

        public class dop_products
        { 
            public int id { get; set; }
            public int dop_id { get; set; }
        }

        //Контейнеры ------------------------------------------------------------------------------------------------------------
        public ObservableCollection<shopViewModel> Products { get; set; }
        shopViewModel _SelectedProduct;

        //События----------------------------------------------------------------------------------------------------------------
        public INavigation Navigation { get; set; }
       /* public string _picker
        {
            get { return }
        }*/
        //Конструктор ------------------------------------------------------------------------------------------------------------
        public shopViewModel()
        {
            List_product_shop = product.Where(m=>m.type == 1).ToList();
        }
        public List<newApiProduct> List_product_shop
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged("List_product_shop");
            }
        }
        //Обработчик нажатия выбора из списка
        public shopViewModel SelectedProduct
        {
            get { return _SelectedProduct;  }
            set {
                //PopupNavigation.PushAsync(new shop_modal());
                //await PopupNavigation.PushAsync(new  ());
                _SelectedProduct = value;
                //тут вызываю обработчик Пикер
                OnPropertyChanged("SelectedFriend");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
