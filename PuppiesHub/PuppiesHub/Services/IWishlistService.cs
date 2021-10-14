using PuppiesHub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    public interface IWishListService
    {
        ObservableCollection <Dog> GetDogWishList();
        bool AddDogToWishList(Dog dog);
        bool RemoveDogFromWishList(Dog dog);

    }
}
