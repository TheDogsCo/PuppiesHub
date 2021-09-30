using Prism.Navigation;
using PuppiesHub.Models;
using PuppiesHub.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    public class HomePageViewModel: BaseViewModel
    {
        public ICommand RequestDogCommand { get; }
        public Dog RandomDog { get; set; }
        private ITheDogsApi _theDogsApi = new TheDogsApi();

        async void OnRequestDog()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                var dogs = await _theDogsApi.GetRandomDog();
                RandomDog = dogs[0];
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No Internet Connection.", "Ok");
            }
        }

        public HomePageViewModel()
        {
            RequestDogCommand = new Command(OnRequestDog);
        }
    }
}
