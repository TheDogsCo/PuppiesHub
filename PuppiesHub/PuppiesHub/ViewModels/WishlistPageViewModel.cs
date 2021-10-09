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
    class WishlistPageViewModel: BaseViewModel
    {
        public ICommand SelectDogCommand { get; } 
        public ObservableCollection<Dog> DogsWishlist { get; set; }

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
            throw new NotImplementedException();
        }

        public WishlistPageViewModel(IWishlistService wishlistService)
        {
            DogsWishlist = wishlistService.GetDogWishlist();
            SelectDogCommand = new Command<Dog>(OnSelectDog);
        }

    }
}
