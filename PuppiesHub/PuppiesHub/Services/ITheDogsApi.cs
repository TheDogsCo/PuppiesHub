using PuppiesHub.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    interface ITheDogsApi
    {
        [Get("/v1/images/search")]
        Task<List<Dog>> GetRandomDog();
    }
}
