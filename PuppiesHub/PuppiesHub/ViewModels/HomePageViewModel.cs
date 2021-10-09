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
        public ICommand AddToWishlistCommand { get; }
        public Dog RandomDog { get; set; }
        ITheDogsApiService _theDogsApiService;
        IPageDialogService _pageDialog;
        IWishlistService _wishlistService;
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
                await _pageDialog.DisplayAlertAsync("Alert", "No Internet Connection.", "Ok");
            }
        }

        async void OnCopyDogImageUrl()
        {
            await Clipboard.SetTextAsync(RandomDog.Url);
            _userDialogs.Toast("Image link copied to Clipboard");
        }

        void OnAddToWishlist()
        {
            _wishlistService.AddDogToWishlist(RandomDog);
            _userDialogs.Toast("Dog added to Wish List");
        }

        public HomePageViewModel(IPageDialogService pageDialog, ITheDogsApiService theDogsApiService, IWishlistService wishlistCacheService, IUserDialogs userDialogs)
        {
            _pageDialog = pageDialog;
            _theDogsApiService = theDogsApiService;
            _wishlistService = wishlistCacheService;
            _userDialogs = userDialogs;

            RequestDogCommand = new Command(OnRequestDog);
            CopyDogUrlCommand = new Command(OnCopyDogImageUrl);
            AddToWishlistCommand = new Command(OnAddToWishlist);
            OnRequestDog();
        }
    }
}
