﻿using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        // refer to the regions of our view

namespace SpellsModule
{
    public class SpellsModule : IModule
    {
        public static IRegionManager regionManager;      // hold refrence to region manager

        public SpellsModule(IRegionManager _regionManager)
        {
            regionManager = _regionManager;
        }

        public void Initialize()
        {
            // --- Register the views for this module with the regions we want to associate them with
            regionManager.RegisterViewWithRegion("PrimaryContentRegion", typeof(View.SpellsViewPrimary));
            regionManager.RegisterViewWithRegion("AuxContentRegion", typeof(View.SpellsViewAux));
        }
    }
}
