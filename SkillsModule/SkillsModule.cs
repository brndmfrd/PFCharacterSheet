using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace SkillsModule
{
    public class SkillsModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public SkillsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(View.SkillsView));
        }
    }
}
