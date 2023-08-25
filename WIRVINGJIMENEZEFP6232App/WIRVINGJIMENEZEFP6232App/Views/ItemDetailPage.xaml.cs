using System.ComponentModel;
using WIRVINGJIMENEZEFP6232App.ViewModels;
using Xamarin.Forms;

namespace WIRVINGJIMENEZEFP6232App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}