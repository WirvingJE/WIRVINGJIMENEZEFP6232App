using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIRVINGJIMENEZEFP6232App.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WIRVINGJIMENEZEFP6232App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListAskPage : ContentPage
    {
        AskViewModel askViewModel; 
        public ListAskPage()
        {
            InitializeComponent();
            BindingContext = askViewModel = new AskViewModel();

            LoadAskList();
        }
        private async void LoadAskList()
        {
            GlobalObjects.MyLocalUser.UserId = 14;

            LvList.ItemsSource = await askViewModel.GetAsksAsync(GlobalObjects.MyLocalUser.UserId);
        }
    }
}