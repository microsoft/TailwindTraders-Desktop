using System.Windows;
using CouponReader.Wpf.CoreModule;
using Prism.Ioc;
using Prism.Modularity;

namespace CouponReader.Wpf
{
    public partial class App 
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CouponReaderModule>();
        }
    }
}