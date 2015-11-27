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
            // Navigation bar view - register with navigation region
            regionManager.RegisterViewWithRegion("NavigationBarRegion", typeof(Views.NavigationBarModuleView));

            // --- Non-specific empty views -- register with associated regions
            // When we just don't want content in a region for certain views
            regionManager.RegisterViewWithRegion("MainRegion", typeof(System.Windows.Controls.UserControl));
            regionManager.RegisterViewWithRegion("PrimaryContentRegion", typeof(System.Windows.Controls.UserControl));
            regionManager.RegisterViewWithRegion("AuxContentRegion", typeof(System.Windows.Controls.UserControl));
        }


    }
}
