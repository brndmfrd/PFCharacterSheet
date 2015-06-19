using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;            // for Inotifypropertychanged
//using Microsoft.Practices.Prism.Mvvm;
using System.Windows.Input;             // ICommand
using Microsoft.Practices.Prism.Regions;    // INavigationAware

namespace NavigationBarModule.ViewModels
{
    public class NavigationBarModuleViewModel : INavigationAware //, INotifyPropertyChanged
    {
        private readonly IRegionManager rm;

        /// <summary>
        /// button press to navigate to Character
        /// </summary>
        public ICommand NavigateToCharacter  
        {
            get { return null; }
        }


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

    }
}
