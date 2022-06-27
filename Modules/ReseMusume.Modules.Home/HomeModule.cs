using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ReseMusume.Core;
using ReseMusume.Modules.Home.Views;

namespace ReseMusume.Modules.Home
{
    public class HomeModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public HomeModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<Views.Home>(RegionNames.ContentRegion);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}