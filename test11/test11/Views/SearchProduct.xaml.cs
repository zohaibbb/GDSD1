using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test11.Helpers;
using test11.Models;
using test11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchProduct : ContentPage
	{
        
        
		public SearchProduct ()
		{
			InitializeComponent ();
           
		}

        private async Task searchBar_SearchButtonPressedAsync(object sender, EventArgs e)
        {
            if (searchBar.Text != null)
            {
                await this.Navigation.PushAsync(new SearchResultView(searchBar.Text));



            }
            return;


































            //IList<Product> product = null;
            //ListView listView=null;
            //if (searchBar.Text != null)
            //{

            //     product = da.getSearchResult(searchBar.Text.ToUpper());
            //}


            //if(product.Count>0)
            //{

            //     listView = new ListView
            //    {
            //        // Source of data items.
            //        ItemsSource = product,

            //        // Define template for displaying each item.
            //        // (Argument of DataTemplate constructor is called for 
            //        //      each item; it must return a Cell derivative.)
            //        ItemTemplate = new DataTemplate(() =>
            //        {
            //            // Create views with bindings for displaying each property.
            //            Label nameLabel = new Label();
            //            nameLabel.SetBinding(Label.TextProperty, "Name");

            //            Label Description = new Label();
            //            Description.SetBinding(Label.TextProperty, "Description");

            //            Image imageLabel = new Image();
            //            imageLabel.Source = "Image_path";


            //            // Return an assembled ViewCell.
            //            return new ViewCell
            //            {
            //                View = new StackLayout
            //                {
            //                    Padding = new Thickness(0, 5),
            //                    Orientation = StackOrientation.Horizontal,
            //                    Children =
            //                    {

            //                        new StackLayout
            //                        {
            //                            VerticalOptions = LayoutOptions.Center,
            //                            Spacing = 0,
            //                            Children =
            //                            {
            //                                nameLabel,
            //                                Description,
            //                                imageLabel
            //                            }
            //                        }
            //                    }
            //                }
            //            };
            //        })
            //    };

            //    searchResult.Children.Add(listView);









        }
    }
}
