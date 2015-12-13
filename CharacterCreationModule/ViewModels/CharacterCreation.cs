using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using ModuleTools;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Input;

namespace CharacterCreationModule.ViewModels
{
    public class CharacterCreation : ObservableObject, INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return Models.NewCharacterContainer.Information; } }
        public IEnumerable<Abilities> Abilities { get { return Models.NewCharacterContainer.AbilityScores; } }
        public IEnumerable<string> Languages { get { return Models.NewCharacterContainer.Languages; } }
        public IEnumerable<CharacterClass> CharacterClasses { get { return Models.NewCharacterContainer.Classes; } }
        public IEnumerable<Item> Items { get { return Models.NewCharacterContainer.Gear; } }
        public IEnumerable<Skill> Skills { get { return Models.NewCharacterContainer.Skills; } }
        public IEnumerable<Feat> Feats { get { return Models.NewCharacterContainer.Feats; } }
        public IEnumerable<Spell> Spells { get { return Models.NewCharacterContainer.Spells; } }

        // ---- save character ----
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
        // ----------------------------------


        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (Models.NewCharacterContainer.Information.Count <= 0)
            {
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Character Name", Value = "Duraxis" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Player Name", Value = "Bryan" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Size", Value = "M" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Alignment", Value = "NG" });
                Models.NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Age", Value = "30" });
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation


    }
}
