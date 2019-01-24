using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Helpers;
using test11.Models;
using test11.QuickSort;
using test11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SortList : ContentPage
	{
        API da = new API();
        public SortList ()
		{

			InitializeComponent ();
            IList<Product> product = da.getProducts();
            QS.QuickSort(product, 0, product.Count - 1);
            BindingContext = product;
        }
	}
}