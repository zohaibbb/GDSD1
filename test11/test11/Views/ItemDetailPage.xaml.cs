using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using test11.Models;
using test11.ViewModels;
using test11.Helpers;

namespace test11.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
       

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            BindingContext = this.viewModel = viewModel;
            InitializeComponent();

            
        }

        private async void Button_Clicked(object sender, ClickedEventArgs e)
        {

            
            
            Product product=viewModel.Item;

            API api = new API();
            
            await api.addToWishListAsync(product.Seller_id, product._Id);




           
           
            InitializeComponent();
            myButton.Text = "Added in Cart";
            myButton.IsEnabled = false;


        }
    }
}