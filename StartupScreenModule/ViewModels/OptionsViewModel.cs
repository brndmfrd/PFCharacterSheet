using Microsoft.Practices.Prism.Regions;
using ModuleTools;
using System.Windows.Input;                 // ICommand
using Archivist;
using System.Collections.Generic;


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {
        public string _filename = "something";

        public string SelectedItem { get; set; }
        public IEnumerable<string> FileList { get { return DirectoryMaster.DirectoryFileList; } }
        public string CurrentFile
        {
            get { return _filename; }
            set
            {
                _filename = value;
                RaisePropertyChangedEvent("CurrentFile");             
            }
        }

        public string CurrentDirectory { get { return CurrentActiveConfig.saveDirectory; } }

        public string LastSaveTimestamp { get { return CurrentActiveConfig.lastSave.ToString(); } }

        #region Commands
        public ICommand LoadNewCharacterCommand { get { return new DelegateCommand(PresentLoadCharacter); } }

        public ICommand ShowSaveCharacterCommand { get { return new DelegateCommand(PresentSaveCharacter); } }

        public ICommand SaveCharacterCommand { get { return new DelegateCommand(SaveCharacter); } }

        public ICommand ConfigCommand { get { return new DelegateCommand(PresentConfiguration); } }

        // User double-clicked a file name
        public ICommand SelectFileCommand { get { return new DelegateCommand(SelectFile); } }
        #endregion Commands

        #region Command Methods
        private void PresentLoadCharacter()
        {
            DirectoryMaster.GetFilesFromDefaultDir();
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.LoadCharacter).FullName);
        }

        private void PresentSaveCharacter()
        {
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.SaveCharacter).FullName);
        }

        private void SaveCharacter()
        {
            CurrentFile = "yo!";
            return;
            if (string.IsNullOrEmpty(CurrentFile))
            {
                SaveCharacterFile.SaveCharacter();
            }
            else
            {
                SaveCharacterFile.SaveCharacter(CurrentFile);
            }
        }

        private void PresentConfiguration()
        {
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.Configuration).FullName);
        }
        #endregion Command Methods

        private void SelectFile()
        {
            // todo: check if SelectedItem is null or irregular.
            LoadCharacterFile.BeginLoadCharacterFile(SelectedItem);
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

