﻿using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using System.Windows.Input;                 // ICommand


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {

        #region Navigation
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
        #endregion Navigation
    }
}

