using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        private CartDataAccess dataAccess;
        public Cart()
        {
            InitializeComponent();
            this.dataAccess = new CartDataAccess();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // The instance of CustomersDataAccess
            // is the data binding source
            this.BindingContext = this.dataAccess;
        }

   
    }
}