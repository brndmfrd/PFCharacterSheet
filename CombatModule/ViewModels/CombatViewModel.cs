using Microsoft.Practices.Prism.Regions;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;
using System;
using ModuleTools;

namespace CombatModule.ViewModels
{
    public class CombatViewModel : ObservableObject, INavigationAware
    {
        #region Navigaion
        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigaion

    }

   
}
