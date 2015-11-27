using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace GearModule
{
    public class GearModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public GearModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            // --- Register the views for this module with the regions we want to associate them with
            regionManager.RegisterViewWithRegion("PrimaryContentRegion", typeof(Views.GearViewControl));
            regionManager.RegisterViewWithRegion("AuxContentRegion", typeof(Views.GearViewControl));
        }
    }
}
