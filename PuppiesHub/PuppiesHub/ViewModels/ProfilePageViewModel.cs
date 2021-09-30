using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    class ProfilePageViewModel: BaseViewModel
    {
        public ICommand LogoutCommand { get; }
        private async void OnLogout() => await _navigationService.NavigateAsync("LoginPage");

        INavigationService _navigationService;

        public ProfilePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LogoutCommand = new Command(OnLogout);
        }

    }
}
