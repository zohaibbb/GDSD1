using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Helpers;
using test11.Models;
using test11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Wishlist : ContentPage
	{
        WishlistViewModel wishlistviewModel;
        public Wishlist ()
		{
            BindingContext = wishlistviewModel = new WishlistViewModel();
            float totalPrice = wishlistviewModel.getTotalPrice();
            InitializeComponent ();
            myLabel.Text = "Total Amount is "+totalPrice;
           
            
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            float price = wishlistviewModel.getTotalPrice();
            API api = new API();
            await api.checkOut(price);





        }
    }
}