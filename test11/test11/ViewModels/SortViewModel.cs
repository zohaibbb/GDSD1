using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using test11.Helpers;
using test11.Models;
using test11.QuickSort;

namespace test11.ViewModels
{
    public class SortViewModel : BaseViewModel
    {

        API da = new API();
        ObservableCollection<Product> items;
        public ObservableCollection<Product> Items
        {
            get => items;
            set { SetProperty(ref items, value); }

        }

        public SortViewModel()
        {
            Title = "Sorted Product List";
            ObservableCollection<Product> pro = new ObservableCollection<Product>(da.getProducts());
            QS.QuickSort(pro, 0, pro.Count - 1);

            Items = pro;



           
        }
    }
}
