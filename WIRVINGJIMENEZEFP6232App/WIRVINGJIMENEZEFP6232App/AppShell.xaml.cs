using System;
using System.Collections.Generic;
using WIRVINGJIMENEZEFP6232App.ViewModels;
using WIRVINGJIMENEZEFP6232App.Views;
using Xamarin.Forms;

namespace WIRVINGJIMENEZEFP6232App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
