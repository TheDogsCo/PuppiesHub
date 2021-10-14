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
        IWishListService _wishListService;
        IUserDialogs _userDialogs;


        void OnRemoveFromWishList()
        {
            _wishListService.AddDogToWishlist(SelectedDog);
            _userDialogs.Toast(MessageAlertConstants.RemovedFromWishList);
        }

        public WishListDetailPageViewModel(IWishListService wishListService, IUserDialogs userDialogs)
        {
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
