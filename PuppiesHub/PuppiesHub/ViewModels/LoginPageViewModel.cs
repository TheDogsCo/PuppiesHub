using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        private async void OnRegister() => await _navigationService.NavigateAsync(NavigationConstants.Paths.Register);
        private async void OnLogin() 
        {

            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                await _dialogService.DisplayAlertAsync("Error", "Favor llenar todos los campos", "OK");

            }

            else
            {
                await _navigationService.NavigateAsync("/" + NavigationConstants.Paths.MainPage);

            }
        }




        INavigationService _navigationService;
        IPageDialogService _dialogService;
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        

    }
}
