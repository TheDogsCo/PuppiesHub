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
            NavigationService.NavigateAsync("HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>("HomePage");
        }


    }
}
