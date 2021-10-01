using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        private async void OnRegister() => await _navigationService.NavigateAsync(NavigationConstants.Paths.Register);
        private async void OnLogin() => await _navigationService.NavigateAsync("/" + NavigationConstants.Paths.MainPage);

        INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

    }
}
