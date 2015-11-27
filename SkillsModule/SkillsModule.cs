﻿using Microsoft.Practices.Prism.Modularity;
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
            // --- Register the views for this module with the regions we want to associate them with
            regionManager.RegisterViewWithRegion("PrimaryContentRegion", typeof(View.SkillsViewPrimary));
            regionManager.RegisterViewWithRegion("AuxContentRegion", typeof(View.SkillsViewPrimary));
        }
    }
}
