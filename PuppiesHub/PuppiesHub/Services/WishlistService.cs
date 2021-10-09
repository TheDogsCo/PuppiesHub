using PuppiesHub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    class WishlistService : IWishlistService
    {

        private ObservableCollection<Dog> _dogsWishlist;

        public WishlistService()
        {
            _dogsWishlist = new ObservableCollection<Dog>();
        }
        public void AddDogToWishlist(Dog dog)
        {
            _dogsWishlist.Add(dog);
        }

        public ObservableCollection<Dog> GetDogWishlist()
        {
            return _dogsWishlist;
        }

        public void RemoveDogFromWishlist(string dogId)
        {
            throw new NotImplementedException();
        }
    }
}
