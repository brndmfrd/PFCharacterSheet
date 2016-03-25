using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using SharedResources.EventHandlers;
using SharedResources.Delegates;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Input;
using CharacterCreationModule.Models;

namespace CharacterCreationModule.ViewModels
{
    public class CharacterCreation : ObservableObject, INavigationAware
    {
        public IEnumerable<BasicInformation> BasicInformation { get { return NewCharacterContainer.Information; }  }
        public IEnumerable<Abilities> Abilities { get { return NewCharacterContainer.AbilityScores; } }
        public IEnumerable<Language> Languages { get { return NewCharacterContainer.Languages; } }
        public IEnumerable<Race> Race { get { return NewCharacterContainer.Race; } }
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
                //Character
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Character Name", Value = "Bryan" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Player Name", Value = "Duraxis" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Size", Value = "M" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Alignment", Value = "NN" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Age", Value = "31" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Diety", Value = "Pelor" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Height", Value = "6'4''" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Weight", Value = "260 lbs" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Homeland", Value = "Muskegon" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Experience Points", Value = "0 xp" });
                NewCharacterContainer.Information.Add(new BasicInformation() { Name = "Hit Points", Value = "23" });

                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Strength", Value = 10 });
                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Dextarity", Value = 10 });
                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Strength", Value = 10 });
                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Dextarity", Value = 10 });
                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Strength", Value = 10 });
                NewCharacterContainer.AbilityScores.Add(new Abilities() { Name = "Dextarity", Value = 10 });

                NewCharacterContainer.Classes.Add(new CharacterClass() { Name = "" });
                NewCharacterContainer.Race.Add(new Race() { Name = "" });
                NewCharacterContainer.Languages.Add(new Language() { Name = "Common" });

                //Gear
                NewCharacterContainer.Gear.Add(new Item() { Name = "Rations", Weight = 1, Amount = 14 });
                NewCharacterContainer.Gear.Add(new Item() { Name = "Tunic and Trousers", Weight = 5, Amount = 1 });
                NewCharacterContainer.Weapons.Add(new Item() { 
                    Name = "Dagger", 
                    Weight = 3, 
                    Amount = 2, 
                    Slot = GearSlots.PrimaryHand,
                    DmgMultiplier = 1,
                    DmgAmount = 4,
                    CrtMultiplier = 2,
                    DmgType = 'P'
                });
                NewCharacterContainer.Armor.Add(new Item() {                     
                    Name = "Leather", 
                    Weight = 15, 
                    Amount = 1, 
                    Slot = GearSlots.Body, 
                    Material = "Leather", 
                    Masterwork = false, 
                    ArmorBonus = 2, 
                    MaxDex = 20,
                    ArmorPenalty = 0,
                    ArcSpellFail = 10,
                    SpeedPenalty = "0"
                });
                NewCharacterContainer.Wonderous.Add(new Item() { 
                    Name = "Ring of Three Wishes", 
                    Weight = 0, 
                    Amount = 1,
                    Description = "Ring with three mounted rubys that each allow the wearer one wish.",
                    Slot = GearSlots.FingerL
                });

                //Skills
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });
                NewCharacterContainer.Skills.Add(new Skill()
                {
                    Name = "Swim",
                    Ranks = 4,
                    Description = "Keeping your head above water",
                    Untrained = true,
                    Ability = "Strength",
                    ArmorCheckPenalty = false
                });

                //Feats
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Dodge",
                    Description = "Dodge bonus to AC (+2)",
                });
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Evasion",
                    Description = "Reflex saves for half-damage are for full damage",
                });
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Power Attack",
                    Description = "Bonus to melee damage (+4). Penalty to accuracy (-2)",
                });
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Mobility",
                    Description = "Move before and after an attack",
                });
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Maximize Spell",
                    Description = "Max roll value on a spell. Uses one slot higher.",
                });
                NewCharacterContainer.Feats.Add(new Feat()
                {
                    Name = "Acrobatics",
                    Description = "Bonus to tumble and balance skills (+2)",
                });

                //Spells
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });
                NewCharacterContainer.Spells.Add(new Spell()
                {
                    Name = "Magic Missle",
                    Description = "Bonus to tumble and balance skills (+2)",
                });



            
            
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation


    }
}
