using Prism.Navigation;
using PuppiesHub.Models;
using PuppiesHub.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    class WishListPageViewModel: BaseViewModel
    {
        public ICommand SelectDogCommand { get; }
        public ObservableCollection<Dog> DogsWishList { get; set; }
        INavigationService _navigationService;

        private Dog _selectedDog;
        public Dog SelectedDog
        {
            get => _selectedDog;
            set
            {
                _selectedDog = value;
                if (_selectedDog != null)
                {
                    SelectDogCommand.Execute(_selectedDog);
                    SelectedDog = null;
                }
            }
        }

        private void OnSelectDog(Dog dog)
        {
            var parameter = new NavigationParameters();
            parameter.Add("dog", dog);
            _navigationService.NavigateAsync(NavigationConstants.Paths.WishListDetail, parameter);
        }

        public WishListPageViewModel(INavigationService navigationService, IWishListService wishlistService)
        {
            _navigationService = navigationService;
            DogsWishList = wishlistService.GetDogWishlist();
            SelectDogCommand = new Command<Dog>(OnSelectDog);
        }

    }
}
