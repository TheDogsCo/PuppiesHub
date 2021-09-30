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
            NavigationService.NavigateAsync(NavigationConstants.Paths.MainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>(NavigationConstants.Paths.MainPage);
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>(NavigationConstants.Paths.Login);
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>(NavigationConstants.Paths.Register);
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>(NavigationConstants.Paths.Home);
            containerRegistry.RegisterForNavigation<WishlistPage, WishlistPageViewModel>(NavigationConstants.Paths.Wishlist);
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>(NavigationConstants.Paths.Profile);
        }


    }
}
