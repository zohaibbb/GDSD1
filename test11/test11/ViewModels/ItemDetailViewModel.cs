using System;

using test11.Models;

namespace test11.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public string DetailTitle { get; set; }
        public Product Item { get; set; }
        public ItemDetailViewModel(Product item = null)
        {
            DetailTitle = "Detail Of The Product";
            Item = item;
        }
    }
}
