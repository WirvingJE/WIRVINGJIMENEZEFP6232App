using System;
using System.Collections.Generic;
using System.ComponentModel;
using WIRVINGJIMENEZEFP6232App.Models;
using WIRVINGJIMENEZEFP6232App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WIRVINGJIMENEZEFP6232App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}