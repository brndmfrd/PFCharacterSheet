using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace SpellsFeatsSkillsModule
{
    public class SpellsFeatsSkillsModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public SpellsFeatsSkillsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.SpellsFeatsSkillsView));
        }
    }
}
