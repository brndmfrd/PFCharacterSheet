using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace CharacterModule
{
    public class CharacterModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        public CharacterModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.CharacterView));
        }
    }
}
