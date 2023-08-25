using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WIRVINGJIMENEZEFP6232App.ViewModels;
using Acr.UserDialogs;


namespace WIRVINGJIMENEZEFP6232App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidaPage : ContentPage
    {
        UserViewModel viewModel;
        public BienvenidaPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel = new UserViewModel();
        }


        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PreguntaPage());




        }

        private async void BtnVerPreguntas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListAskPage());
        }
    }
}
