using Prism;
using Prism.Ioc;
using Prism.Unity;
using PuppiesHub.ViewModels;
using PuppiesHub.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuppiesHub
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer): base(platformInitializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>("MainPage");
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("LoginPage");
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>("RegisterPage");
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>("HomePage");
            containerRegistry.RegisterForNavigation<WishlistPage, WishlistPageViewModel>("WishlistPage");
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>("ProfilePage");
        }


    }
}
