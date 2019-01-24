﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}