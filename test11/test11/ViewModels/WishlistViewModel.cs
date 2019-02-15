using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using test11.Helpers;
using test11.Models;
using Xamarin.Forms;

namespace test11.ViewModels
{
    public class WishlistViewModel : BaseViewModel
    {
        API da = new API();
        ObservableCollection<Product> items;
        public ObservableCollection<Product> Items
        {
            get => items;
            set { SetProperty(ref items, value); }

        }
        
        float price;
        public Command LoadItemsCommand { get; set; }

        public WishlistViewModel()
        {
            Title = "My WishLish";
            Items = new ObservableCollection<Product>(da.getWishList());
            for(int i =0;i<Items.Count;i++)
            price += Items[i].Price;

            

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }
        public float getTotalPrice()
        {
            return price;
        }

        async Task ExecuteLoadItemsCommand()
        {


            try
            {
                IsRefreshing = true;
                Items.Clear();
                Items = new ObservableCollection<Product>(da.getWishList());


                IsRefreshing = false;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                //IsBusy = false;
            }
        }
    }
}
