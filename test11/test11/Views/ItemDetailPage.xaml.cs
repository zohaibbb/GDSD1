using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using test11.Models;
using test11.ViewModels;

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

        
    }
}