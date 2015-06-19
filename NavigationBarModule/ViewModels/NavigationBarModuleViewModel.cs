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
        /// <summary>
        /// button press to navigate to Character
        /// </summary>
        public ICommand NavigateToCharacter
        {
            get { return new RelayCommand(ToCharacter); }

        }

        private void ToCharacter()
        {
            NavigationBarModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterModule.Views.CharacterView).FullName);
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
