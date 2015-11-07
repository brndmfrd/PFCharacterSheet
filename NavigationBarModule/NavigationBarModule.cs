using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace NavigationBarModule
{
    public class NavigationBarModule : IModule
    {
        public static IRegionManager regionManager;

        public NavigationBarModule(IRegionManager _regionManager)
        {
          regionManager = _regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("NavigationBarRegion", typeof(Views.NavigationBarModuleView));
        }


    }
}
