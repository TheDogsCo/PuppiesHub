﻿using PuppiesHub.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuppiesHub.Services
{
    class TheDogsApi : ITheDogsApi
    {
        public Task<List<Dog>> GetRandomDog()
        {
            var theDogAPI = RestService.For<ITheDogsApi>("https://api.thedogapi.com");
            return theDogAPI.GetRandomDog();
        }
    }
}