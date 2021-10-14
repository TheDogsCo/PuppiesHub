using Acr.UserDialogs;
using Prism.Navigation;
using PuppiesHub.Models;
using PuppiesHub.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    public class WishListDetailPageViewModel : BaseViewModel, IInitialize
    {
        public ICommand RemoveFromWishListCommand { get; }

        public Dog SelectedDog { get; set; }
        INavigationService _navigationService;
        IWishListService _wishListService;
        IUserDialogs _userDialogs;


        async void OnRemoveFromWishList()
        {
            _wishListService.RemoveDogFromWishList(SelectedDog);
            _userDialogs.Toast(MessageAlertConstants.RemovedFromWishList);
            await _navigationService.GoBackAsync();
        }

        public WishListDetailPageViewModel(INavigationService navigationService, IWishListService wishListService, IUserDialogs userDialogs)
        {
            _navigationService = navigationService;
            _wishListService = wishListService;
            _userDialogs = userDialogs;

            RemoveFromWishListCommand = new Command(OnRemoveFromWishList);
        }

        public void Initialize(INavigationParameters parameters)
        {
            SelectedDog = (Dog)parameters["dog"];
        }
    }
}
