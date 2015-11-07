using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace FeatsModule
{
    public class FeatsModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public FeatsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(View.FeatsView));
        }
    }
}
