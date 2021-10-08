using Prism.Navigation;
using Prism.Services;
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
        public ICommand CopyDogUrlCommand { get; }
        public Dog RandomDog { get; set; }
        ITheDogsApiService _theDogsApiService;
        IPageDialogService _pageDialog;

        async void OnRequestDog()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                List<Dog> dogs;
                do
                {
                    dogs = await _theDogsApiService.GetRandomDog();
                } while (dogs[0].Breeds.Count == 0);

                RandomDog = dogs[0];
            }
            else
            {
                await _pageDialog.DisplayAlertAsync("Alert", "No Internet Connection.", "Ok");
            }
        }

        async void OnCopyDogImageUrl()
        {
            await Clipboard.SetTextAsync(RandomDog.Url);
        }

        public HomePageViewModel(IPageDialogService pageDialog, ITheDogsApiService theDogsApiService)
        {
            _pageDialog = pageDialog;
            _theDogsApiService = theDogsApiService;
            RequestDogCommand = new Command(OnRequestDog);
            CopyDogUrlCommand = new Command(OnCopyDogImageUrl);
        }
    }
}
