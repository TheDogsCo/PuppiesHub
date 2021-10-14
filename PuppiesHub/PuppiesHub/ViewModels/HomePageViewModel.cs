using Acr.UserDialogs;
using Prism.Services;
using PuppiesHub.Models;
using PuppiesHub.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    public class HomePageViewModel: BaseViewModel
    {
        public ICommand RequestDogCommand { get; }
        public ICommand CopyDogUrlCommand { get; }
        public ICommand AddToWishListCommand { get; }
        public Dog RandomDog { get; set; }
        ITheDogsApiService _theDogsApiService;
        IWishListService _wishListService;
        IUserDialogs _userDialogs;

        async void OnRequestDog()
        {
            NetworkAccess current = Connectivity.NetworkAccess;
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
                await _userDialogs.AlertAsync(MessageAlertConstants.NoInternetConnection);
            }
        }

        async void OnCopyDogImageUrl()
        {
            await Clipboard.SetTextAsync(RandomDog.Url);
            _userDialogs.Toast(MessageAlertConstants.ImageCopiedToClipboard);
        }

        void OnAddToWishList()
        {
            var wasAdded = _wishListService.AddDogToWishList(RandomDog);
            if (wasAdded)
            {
                _userDialogs.Toast(MessageAlertConstants.AddedToWishList);
            } else
            {
                _userDialogs.Toast(MessageAlertConstants.AlreadyOnWishList);
            }

        }

        public HomePageViewModel(ITheDogsApiService theDogsApiService, IWishListService wishListService, IUserDialogs userDialogs)
        {
            _theDogsApiService = theDogsApiService;
            _wishListService = wishListService;
            _userDialogs = userDialogs;

            RequestDogCommand = new Command(OnRequestDog);
            CopyDogUrlCommand = new Command(OnCopyDogImageUrl);
            AddToWishListCommand = new Command(OnAddToWishList);
            OnRequestDog();
        }
    }
}
