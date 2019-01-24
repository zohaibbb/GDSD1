using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Models;
using test11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchResultView : ContentPage
	{
        SearchViewModel searchViewModel;
		public SearchResultView (string keyword)
		{
			InitializeComponent ();
            BindingContext = searchViewModel = new SearchViewModel(keyword);
		}

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Product;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

    }
}