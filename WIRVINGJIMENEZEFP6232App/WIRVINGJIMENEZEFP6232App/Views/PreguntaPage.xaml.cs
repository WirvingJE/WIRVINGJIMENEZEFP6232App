using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIRVINGJIMENEZEFP6232App.Models;
using WIRVINGJIMENEZEFP6232App.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WIRVINGJIMENEZEFP6232App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreguntaPage : ContentPage
    {
        UserViewModel viewmodel;
        public PreguntaPage()
        {
            InitializeComponent();
            BindingContext = viewmodel = new UserViewModel();
            LoadAskStatusAsync();



        }

        private async void LoadAskStatusAsync()
        {
            PkrAskStatus.ItemsSource = await viewmodel.GetAskStatusAsync();
        }



        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
        

            AskStatus SelectedAskStatus = PkrAskStatus.SelectedItem as AskStatus;

            bool R = await viewmodel.AddAskAsync(DateTime.Now,
                                                  TxtAsk.Text.Trim(),
                                                  GlobalObjects.MyLocalUser.UserId,
                                                  TxtImageURL.Text.Trim(),
                                                  TxtAskDetail.Text.Trim(),
                                                  SelectedAskStatus.AskStatusId);

            if (R)
            {
                await DisplayAlert(":0", "User created Ok!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":(", "Something went wrong...", "OK");
            }


        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }

}