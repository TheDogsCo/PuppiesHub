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
        private async void OnRegister() => await _navigationService.NavigateAsync("RegisterPage");

        INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            RegisterCommand = new Command(OnRegister);
        }

    }
}
