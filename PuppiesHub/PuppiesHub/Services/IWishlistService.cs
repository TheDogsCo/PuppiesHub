using PuppiesHub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    public interface IWishlistService
    {
        ObservableCollection <Dog> GetDogWishlist();
        void AddDogToWishlist(Dog dog);
        void RemoveDogFromWishlist(string dogId);

    }
}
