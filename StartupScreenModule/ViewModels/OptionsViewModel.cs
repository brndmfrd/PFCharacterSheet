using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using System.Windows.Input;                 // ICommand
using Archivist;
using System.Collections.Generic;


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {
        private string titleContent = "TitleContent";

        public IEnumerable<string> FileList { get { return DirectoryMaster.DirectoryFileList; } }
        public string TitleContent { get { return titleContent; } set { RaisePropertyChangedEvent("TitleContent"); titleContent = value; } } // set from OptionsViewPrimary button press (Save, Load, etc)
        public string StatusContent { get { return ""; } } // set from Archivist
        public string AlertContent { get { return ""; } } // set from Archivist

        public ICommand LoadNewCharacterCommand
        {
            get { return new DelegateCommand(PresentLoadCharacter); }
        }

        public ICommand SaveCharacterCommand
        {
            get { return new DelegateCommand(PresentSaveCharacter); }
        }

        public ICommand ConfigCommand
        {
            get { return new DelegateCommand(PresentConfiguration); }
        }

        private void PresentLoadCharacter()
        {
            TitleContent = "Load Character";
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.LoadCharacter).FullName);
        }

        private void PresentSaveCharacter()
        {
            TitleContent = "Save Character";
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.SaveCharacter).FullName);
        }

        private void PresentConfiguration()
        {
            TitleContent = "Configuration";
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.Configuration).FullName);
        }

        public ICommand SelectFileCommand
        {
            get
            {
                return new DelegateCommand(SelectFile);
            }
        }

        private void SelectFile()
        {
            var x = SelectedItem;
        }

        private string selectedItem = "noItem";
        public string SelectedItem { 
            get { return selectedItem; }
            set { selectedItem = value; } 
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

