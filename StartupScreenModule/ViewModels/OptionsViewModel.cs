using Microsoft.Practices.Prism.Regions;
using SharedResources;
using SharedResources.Delegates;
using SharedResources.EventHandlers;
using System.Windows.Input;                 // ICommand
using Archivist;
using System.Collections.Generic;


namespace OptionsModule.ViewModels
{
    public class OptionsViewModel : ObservableObject, INavigationAware
    {
        #region Fields
        private string _currentFile = CurrentActiveConfig.filename;
        private bool loadButtonToggle = false;
        private bool saveBeforeLoadToggle = false;
        #endregion Fields

        #region Properties
        public string SelectedItem { get; set; }

        public IEnumerable<string> FileList { get { return DirectoryMaster.DirectoryFileList; } }

        public string CurrentFile
        {
            get { return _currentFile; }
            set 
            {
                _currentFile = value; 
                RaisePropertyChangedEvent("CurrentFile"); 
            }
        }

        public string CurrentDirectory { get { return CurrentActiveConfig.saveDirectory; } }

        public string LastSaveTimestamp { get { return CurrentActiveConfig.lastSave.ToString(); } }

        public bool LoadButtonToggle
        {
            get { return loadButtonToggle; }
            set
            {
                loadButtonToggle = value;
                RaisePropertyChangedEvent("LoadButtonToggle");
            }
        }

        public bool SaveBeforeLoadToggle
        {
            get { return saveBeforeLoadToggle; }
            set
            {
                saveBeforeLoadToggle = value;
                RaisePropertyChangedEvent("SaveBeforeLoadToggle");
            }
        }

        #endregion Properties

        #region Commands
        public ICommand LoadNewCharacterCommand { get { return new DelegateCommand(PresentLoadCharacter); } }

        public ICommand ShowSaveCharacterCommand { get { return new DelegateCommand(PresentSaveCharacter); } }

        public ICommand SaveCharacterCommand { get { return new DelegateCommand(SaveCharacter); } }

        public ICommand UndoCharacterCommand { get { return new DelegateCommand(UndoUserChanges); } }

        public ICommand ConfigCommand { get { return new DelegateCommand(PresentConfiguration); } }

        // User double-clicked a file name
        public ICommand SelectFileCommand { get { return new DelegateCommand(SelectFile); } }

        public ICommand ComfirmLoadCommand { get { return new DelegateCommand(ConfirmLoad); } }

        public ICommand SaveBeforeLoadCommand { get { return new DelegateCommand(SaveCharacter); } }
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

        private void UndoUserChanges()
        {
            CurrentFile = CurrentActiveConfig.filename;
        }

        private void SaveCharacter()
        {
            if (string.IsNullOrEmpty(_currentFile))
            {
                SaveCharacterFile.SaveCharacter();
            }
            else
            {
                SaveCharacterFile.SaveCharacter(_currentFile);
            }

            SaveBeforeLoadToggle = false; 
        }

        private void PresentConfiguration()
        {
            OptionsModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.Configuration).FullName);
        }

        private void SelectFile()
        {
            LoadButtonToggle = true;
            SaveBeforeLoadToggle = true;          
        }

        private void ConfirmLoad()
        {
            // todo: check if SelectedItem is null or irregular.
            LoadCharacterFile.BeginLoadCharacterFile(SelectedItem);
            LoadButtonToggle = false;
        }
        #endregion Command Methods        

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

