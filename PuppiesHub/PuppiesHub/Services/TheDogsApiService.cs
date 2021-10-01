using PuppiesHub.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    public class TheDogsApiService : ITheDogsApiService
    {
        public Task<List<Dog>> GetRandomDog()
        {
            var theDogAPI = RestService.For<ITheDogsApiService>(ConfigurationConstants.Urls.Domain);
            return theDogAPI.GetRandomDog();
        }
    }
}
