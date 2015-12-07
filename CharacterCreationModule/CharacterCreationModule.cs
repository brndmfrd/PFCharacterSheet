using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace CharacterCreationModule
{
    public class CharacterCreationModule : IModule
    {
        public static IRegionManager regionManager;      // hold refrence to region manager

        public CharacterCreationModule(IRegionManager _regionManager)
        {
            regionManager = _regionManager;
        }

        public void Initialize()
        {
            // --- Register the views for this module with the regions we want to associate them with
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.Setup));
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.BasicInfo));
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.Feats));
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.Gear));
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.Skills));
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.Spells));
        }
    }
}
