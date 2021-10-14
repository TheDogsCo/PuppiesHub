using PuppiesHub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    class WishListService : IWishListService
    {

        private ObservableCollection<Dog> _dogsWishList;

        public WishListService()
        {
            _dogsWishList = new ObservableCollection<Dog>();
        }
        public bool AddDogToWishList(Dog dog)
        {
            if (!_dogsWishList.Contains(dog))
            {
                _dogsWishList.Add(dog);
                return true;
            }
            return false;
        }

        public ObservableCollection<Dog> GetDogWishList()
        {
            return _dogsWishList;
        }

        public bool RemoveDogFromWishList(Dog dog)
        {
            if (_dogsWishList.Contains(dog))
            {
                _dogsWishList.Remove(dog);
                return true;
            }
            return false;
        }
    }
}
