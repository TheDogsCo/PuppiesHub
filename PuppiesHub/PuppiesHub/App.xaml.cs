using Prism;
using Prism.Ioc;
using Prism.Unity;
using PuppiesHub.Services;
using PuppiesHub.ViewModels;
using PuppiesHub.Views;
using System;
using Unity.Lifetime;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuppiesHub
{
    public partial class App : PrismApplication
    {
        static TheDogsApiService theDogsApiService = new TheDogsApiService();
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
            containerRegistry.RegisterInstance<ITheDogsApiService>(theDogsApiService);
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>(NavigationConstants.Paths.MainPage);
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>(NavigationConstants.Paths.Login);
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>(NavigationConstants.Paths.Register);
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>(NavigationConstants.Paths.Home);
            containerRegistry.RegisterForNavigation<WishlistPage, WishlistPageViewModel>(NavigationConstants.Paths.Wishlist);
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>(NavigationConstants.Paths.Profile);
        }


    }
}
