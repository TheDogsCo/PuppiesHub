using Acr.UserDialogs;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PuppiesHub.Services;
using PuppiesHub.ViewModels;
using PuppiesHub.Views;
using Xamarin.Forms;

namespace PuppiesHub
{
    public partial class App : PrismApplication
    {
        static IWishListService wishListService = new WishListService();
        public App(IPlatformInitializer platformInitializer): base(platformInitializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"/NavigationPage/{NavigationConstants.Paths.Login}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ITheDogsApiService, TheDogsApiService>();
            containerRegistry.RegisterInstance<IWishListService>(wishListService);
            containerRegistry.RegisterInstance<IUserDialogs>(UserDialogs.Instance);
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>(NavigationConstants.Paths.MainPage);
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>(NavigationConstants.Paths.Login);
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>(NavigationConstants.Paths.Register);
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>(NavigationConstants.Paths.Home);
            containerRegistry.RegisterForNavigation<WishListPage, WishListPageViewModel>(NavigationConstants.Paths.WishList);
            containerRegistry.RegisterForNavigation<WishListDetailPage, WishListDetailPageViewModel>(NavigationConstants.Paths.WishListDetail);
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>(NavigationConstants.Paths.Profile);
        }


    }
}
