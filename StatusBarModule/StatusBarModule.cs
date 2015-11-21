using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;        

namespace StatusBarModule
{
    public class StatusBarModule : IModule
    {
        private readonly IRegionManager regionManager;

        public StatusBarModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("StatusEffectsRegion", typeof(View.StatusBarView));
        }
    }
}
