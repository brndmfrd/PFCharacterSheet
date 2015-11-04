using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace OptionsModule
{
    public class OptionsModule : IModule
    {
        private readonly IRegionManager regionManager;      // hold refrence to region manager

        // obtain a region manager instance through constructor dependency injection and store it in the regionManager instance variable
        public OptionsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            //  registers a region name with its associated view type in the region view registry
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.OptionsView));
        }


    }
}
