using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
