using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using test11.Models;
using test11.Views;
using test11.Helpers;

namespace test11.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        API da = new API();
        ObservableCollection<Product> items;
        public ObservableCollection<Product> Items
        {
            get => items;
            set { SetProperty(ref items, value); }

        }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Fulda Buy And Sell";
            Items = new ObservableCollection<Product>(da.getProducts());



            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
          

            try
            {
                IsRefreshing = true;
                Items.Clear();
                Items = new ObservableCollection<Product>(da.getProducts());


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