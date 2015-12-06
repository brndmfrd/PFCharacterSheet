using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using System.Windows.Input;                 // ICommand


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {
        public ICommand CreateNewCharacterCommand
        {
            get { return new DelegateCommand(ToCharacterCreation); }
        }

        public void ToCharacterCreation()
        {
            OptionsModule.regionManager.RequestNavigate("MainRegion", typeof(CharacterCreationModule.Views.Setup).FullName);
        }

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

