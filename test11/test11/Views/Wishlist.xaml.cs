using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Helpers;
using test11.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Wishlist : ContentPage
	{
		public Wishlist ()
		{
            API api = new API();

            ObservableCollection<Product> product = api.getWishList();
            InitializeComponent ();
            
            BindingContext = product;
        }
	}
}