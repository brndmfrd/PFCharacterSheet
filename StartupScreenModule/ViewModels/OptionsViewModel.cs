using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using System.Windows.Input;                 // ICommand
using Archivist;
using System.Collections.Generic;


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {
        private string selectedItem = "noItem";


        public IEnumerable<string> FileList { get { return DirectoryMaster.DirectoryFileList; } }
        
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

            // used to invoke the get on FileList
            var x = FileList;

            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.LoadCharacter).FullName);
        }

        private void PresentSaveCharacter()
        {
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.SaveCharacter).FullName);
        }

        private void PresentConfiguration()
        {
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

