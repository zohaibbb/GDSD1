using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using test11.Helpers;
using test11.Models;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace test11.ViewModels
{
    public class SearchViewModel:BaseViewModel
    {
        API da = new API();
        ObservableCollection<Product> searchProducts;
        public ObservableCollection<Product> SearchProducts
        {
            get => searchProducts;
            set { SetProperty(ref searchProducts, value); }

        }
        public Command LoadItemsCommand { get; set; }
        public SearchViewModel(string keyword)
        {
            Title = "Search Result";
            SearchProducts = new ObservableCollection<Product>(da.getSearchResult(keyword));



            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        //async Task ExecuteLoadItemsCommand()
        //{
        //    if (IsBusy)
        //        return;

        //    IsBusy = true;

        //    try
        //    {
        //        SearchProducts.Clear();
        //        SearchProducts = new ObservableCollection<Product>(da.getProducts());


        //        IsBusy = false;
        //    }

        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}


    }
}
