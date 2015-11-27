using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace CombatModule
{
    public class CombatModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public CombatModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.CombatViewControl));
        }
    }
}
