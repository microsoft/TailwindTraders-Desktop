using CouponReader.Wpf.Module;
using CouponReader.Wpf.Module.Services;
using CouponReader.Wpf.Module.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CouponReader.Wpf.CoreModule
{
    public class CouponReaderModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.ContentRegion, "LoginView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginView>();
            containerRegistry.RegisterForNavigation<MainView>();

            containerRegistry.Register<LoginService>();
        }
    }
}