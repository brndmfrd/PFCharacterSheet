using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using ModuleTools;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Input;
using CharacterCreationModule.Models;

namespace CharacterCreationModule.ViewModels
{
    public class CharacterCreation : ObservableObject, INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return NewCharacterContainer.Information; }  }
        public IEnumerable<Abilities> Abilities { get { return NewCharacterContainer.AbilityScores; }  }
        public IEnumerable<string> Languages { get { return NewCharacterContainer.Languages; }  }
        public IEnumerable<CharacterClass> CharacterClasses { get { return NewCharacterContainer.Classes; }  }
        public IEnumerable<Item> Gear { get { return NewCharacterContainer.Gear; } }
        public IEnumerable<Item> Weapons { get { return NewCharacterContainer.Weapons; } }
        public IEnumerable<Item> Armor { get { return NewCharacterContainer.Armor; } }
        public IEnumerable<Item> Wonderous { get { return NewCharacterContainer.Wonderous; } }
        public IEnumerable<Skill> Skills { get { return NewCharacterContainer.Skills; } }
        public IEnumerable<Feat> Feats { get { return NewCharacterContainer.Feats; }  }
        public IEnumerable<Spell> Spells { get { return NewCharacterContainer.Spells; }  }


        // todo: put this save character block in a class of its own
        // ---- save character ---- save character ---- save character ---- save character ----
        private string saveFileName = "Default Name";
        private string saveFilePath = "Default Path";
        private string saveConfirmation;
        public ICommand SaveCharacterCommand { get { return new DelegateCommand(SaveCharacter); } }
        public ICommand SelectPathExplorerCommand { get { return new DelegateCommand(SelectPathExplorer); } }
        
        public string SaveFileName { get { return saveFileName; } set { saveFileName = value; RaisePropertyChangedEvent("SaveFileName"); } }
        public string SaveFilePath { get { return saveFilePath; } set { saveFilePath = value; RaisePropertyChangedEvent("SaveFilePath"); } }
        public string SaveConfirmation { get { return saveConfirmation; } set { saveConfirmation = value; RaisePropertyChangedEvent("SaveConfirmation"); } }

        private void SaveCharacter()
        {
            SaveConfirmation = "Confirming Save, please wait--";
            // todo:
            // sanitize strings (file and path)
            // perform file and path validation (can we write this file to this location?)
            // write to file (or overwrite file) using json formatting
            SaveConfirmation = string.Format("Success! \n File was saved at {0} \n File Name: {1} \n File Path: {2}", DateTime.Now, SaveFileName, SaveFilePath);
        }
        private void SelectPathExplorer()
        {
            // -- Open windows file explorer --
            var ofd = new Microsoft.Win32.OpenFileDialog();
            //ofd.DefaultExt = ".pf";
            ofd.Multiselect = false;
            ofd.DefaultExt = ".pf";
            ofd.AddExtension = true;
            ofd.Filter = "Pathfinder Files (*.pf)|*.pf|All Files (*.*)|*.*";
            //ofd.InitialDirectory(SaveFilePath);
            var success = ofd.ShowDialog();                     // returns nullable bool

            // -- success is FALSE if user selects "Cancel" on the dialog
            if (success != true)
            {
                return;
            }

            // True if the user has changed the file name
            if (ofd.FileName.CompareTo(SaveFileName) != 0)
            {
                if (ofd.FileName.EndsWith(".pf"))
                {
                    var splitpath = ofd.FileName.Split('\\');
                    SaveFileName = splitpath[splitpath.Length - 1];
                    SaveFilePath = ofd.FileName.Substring(0, ofd.FileName.Length - SaveFileName.Length);
                }
                else
                {
                    var fullPath = ofd.FileName + ".pf";
                    var splitpath = fullPath.Split('\\');
                    SaveFileName = splitpath[splitpath.Length - 1];
                    SaveFilePath = ofd.FileName.Substring(0, fullPath.Length - SaveFileName.Length);
                }
            }
        }
        //  save character ---- save character ---- save character ---- save character ----


        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (NewCharacterContainer.Information.Count <= 0)
            {
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Character Name", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Player Name", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Size", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Alignment", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Age", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Diety", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Height", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Weight", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Homeland", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Experience Points", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Hit Points", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Strength", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Dextarity", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Constitution", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Intelligence", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Wisdom", Value = "" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Charisma", Value = "" });

            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation


    }
}
