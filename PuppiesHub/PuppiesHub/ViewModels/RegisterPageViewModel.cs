using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuppiesHub.ViewModels
{
    class RegisterPageViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string NewPassword { get; set; }
        public string PasswordConfirmation { get; set; }

        public ICommand RegisterCommand { get; }
        private async void OnRegister() => await _navigationService.NavigateAsync(NavigationConstants.Paths.Login);
        private async void OnLogin()
        {

            if (String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(NewPassword) || String.IsNullOrEmpty(PasswordConfirmation))
            {
                await _dialogService.DisplayAlertAsync("Error", "Favor llenar todos los campos", "OK");
            }

            else
            {
                await _dialogService.DisplayAlertAsync("Bienvenido!", $"{Username}", "OK");
                await _navigationService.NavigateAsync("/" + NavigationConstants.Paths.MainPage);

            }
        }




        INavigationService _navigationService;
        IPageDialogService _dialogService;
        public RegisterPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
            RegisterCommand = new Command(OnRegister);
        }
    }
}
