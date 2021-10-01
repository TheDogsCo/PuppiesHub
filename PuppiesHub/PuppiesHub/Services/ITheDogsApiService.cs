using PuppiesHub.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    public interface ITheDogsApiService
    {
        [Get(ConfigurationConstants.Urls.Search)]
        Task<List<Dog>> GetRandomDog();
    }
}
