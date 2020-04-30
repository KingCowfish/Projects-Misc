﻿using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HPlusSports
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Item_Selected(object sender, SelectionChangedEventArgs e)
        {
            Services.Product product = e.CurrentSelection.First() as Services.Product;
            Navigation.PushAsync(new ProductDetail(product));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            INetworkManager mgr = DependencyService.Get<INetworkManager>();
            if (mgr != null && mgr.IsNetworkConnected())
            {
                var products = await ProductService.GetProductsAsync();
                BindingContext = products;
            }
            else
            {
                await DisplayAlert("Not Connected", "You are not connected to the network", "OK");
            }
        }
    }
}
