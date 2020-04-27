using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(MainPage());
        }

        protected override void OnStart()
        {
            Services.ProductService.LoadWishList();
        }

        protected override void OnSleep()
        {
            //Services.Product.SaveWishList();
        }

        protected override void OnResume()
        {
            //Services.Product.LoadWishList();
        }
    }
}
