using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;
using CharacterModule.Model;
using ModuleTools;


namespace CharacterModule.ViewModels
{
    public class CharacterViewModel : ObservableObject, INavigationAware
    {

        //public string CharacterName { get { return CharacterModel.CharacterName; } set { CharacterModel.CharacterName = value; RaisePropertyChangedEvent("CharacterName"); } }
        //public string PlayerName { get { return CharacterModel.PlayerName; } set { CharacterModel.PlayerName = value; RaisePropertyChangedEvent("PlayerName"); } }
        //public string Race { get { return CharacterModel.Race; } set { CharacterModel.Race = value; RaisePropertyChangedEvent("Race"); } }
        //public string Size { get { return CharacterModel.Size; } set { CharacterModel.Size = value; RaisePropertyChangedEvent("Size"); } }
        //public string Alignment { get { return CharacterModel.Alignment; } set { CharacterModel.Alignment = value; RaisePropertyChangedEvent("Alignment"); } }
        //public string Age { get { return CharacterModel.Age; } set { CharacterModel.Age = value; RaisePropertyChangedEvent("Age"); } }
        //public string Deity { get { return CharacterModel.Deity; } set { CharacterModel.Deity = value; RaisePropertyChangedEvent("Diety"); } }
        //public string Gender { get { return CharacterModel.Gender; } set { CharacterModel.Gender = value; RaisePropertyChangedEvent("Gender"); } }
        //public string Height { get { return CharacterModel.Height; } set { CharacterModel.Height = value; RaisePropertyChangedEvent("Height"); } }
        //public string Weight { get { return CharacterModel.Weight; } set { CharacterModel.Weight = value; RaisePropertyChangedEvent("Weight"); } }
        //public string Eyes { get { return CharacterModel.Eyes; } set { CharacterModel.Eyes = value; RaisePropertyChangedEvent("Eyes"); } }
        //public string Hair { get { return CharacterModel.Hair; } set { CharacterModel.Hair = value; RaisePropertyChangedEvent("Hair"); } }
        //public string Homeland { get { return CharacterModel.Homeland; } set { CharacterModel.Homeland = value; RaisePropertyChangedEvent("Homeland"); } }
        //public string Strength { get { return CharacterModel.Strength; } set { CharacterModel.Strength = value; RaisePropertyChangedEvent("Strength"); } }
        //public string Dexterity { get { return CharacterModel.Dexterity; } set { CharacterModel.Dexterity = value; RaisePropertyChangedEvent("Dexterity"); } }
        //public string Constitution { get { return CharacterModel.Constitution; } set { CharacterModel.Constitution = value; RaisePropertyChangedEvent("Constitution"); } }
        //public string Intelligence { get { return CharacterModel.Intelligence; } set { CharacterModel.Intelligence = value; RaisePropertyChangedEvent("Intelligence"); } }
        //public string Wisdom { get { return CharacterModel.Wisdom; } set { CharacterModel.Wisdom = value; RaisePropertyChangedEvent("Wisdom"); } }
        //public string Charisma { get { return CharacterModel.Charisma; } set { CharacterModel.Charisma = value; RaisePropertyChangedEvent("Charisma"); } }
        //public string Common { get { return CharacterModel.Common; } set { CharacterModel.Common = value; RaisePropertyChangedEvent("Common"); } }
        //public string Dwarven { get { return CharacterModel.Dwarven; } set { CharacterModel.Dwarven = value; RaisePropertyChangedEvent("CharacterName"); } }
        //public string Draconic { get { return CharacterModel.Draconic; } set { CharacterModel.Draconic = value; RaisePropertyChangedEvent("Dwarven"); } }
        //public string ExperiencePoints { get { return CharacterModel.ExperiencePoints; } set { CharacterModel.ExperiencePoints = value; RaisePropertyChangedEvent("ExperiencePoints"); } }
        //public string Barbarian { get { return CharacterModel.Barbarian; } set { CharacterModel.Barbarian = value; RaisePropertyChangedEvent("Barbarian"); } }
        //public string Bard { get { return CharacterModel.Bard; } set { CharacterModel.Bard = value; RaisePropertyChangedEvent("Bard"); } }
        //public string Cleric { get { return CharacterModel.Cleric; } set { CharacterModel.Cleric = value; RaisePropertyChangedEvent("Cleric"); } }
        //public string Druid { get { return CharacterModel.Druid; } set { CharacterModel.Druid = value; RaisePropertyChangedEvent("Druid"); } }
        //public string Fighter { get { return CharacterModel.Fighter; } set { CharacterModel.Fighter = value; RaisePropertyChangedEvent("Fighter"); } }
        //public string Ranger { get { return CharacterModel.Ranger; } set { CharacterModel.Ranger = value; RaisePropertyChangedEvent("Ranger"); } }
        //public string Sorcerer { get { return CharacterModel.Sorcerer; } set { CharacterModel.Sorcerer = value; RaisePropertyChangedEvent("Sorcerer"); } }
        //public string Wizard { get { return CharacterModel.Wizard; } set { CharacterModel.Wizard = value; RaisePropertyChangedEvent("Wizard"); } }

        
        // ---------------------------
        //public ICommand ChangeStrengthCommand { get { return new DelegateCommand(ChangeStrength); } }
        //public ICommand ChangeDexterityCommand { get { return new DelegateCommand(ChangeDexterity); } }
        //public ICommand ChangeConstitutionCommand { get { return new DelegateCommand(ChangeConstitution); } }
        //public ICommand ChangeIntelligenceCommand { get { return new DelegateCommand(ChangeIntelligence); } }
        //public ICommand ChangeWisdomCommand { get { return new DelegateCommand(ChangeWisdom); } }
        //public ICommand ChangeCharismaCommand { get { return new DelegateCommand(ChangeCharisma); } }
        //public ICommand ChangeCharacterNameCommand { get { return new DelegateCommand(ChangeCharacterName); } }
        //public ICommand ChangePlayerNameCommand { get { return new DelegateCommand(ChangePlayerName); } }
        //public ICommand ChangeRaceCommand { get { return new DelegateCommand(ChangeRace); } }
        //public ICommand ChangeSizeCommand { get { return new DelegateCommand(ChangeSize); } }
        //public ICommand ChangeAlignmentCommand { get { return new DelegateCommand(ChangeAlignment); } }
        //public ICommand ChangeAgeCommand { get { return new DelegateCommand(ChangeAge); } }
        //public ICommand ChangeDeityCommand { get { return new DelegateCommand(ChangeDeity); } }
        //public ICommand ChangeGenderCommand { get { return new DelegateCommand(ChangeGender); } }
        //public ICommand ChangeHeightCommand { get { return new DelegateCommand(ChangeHeight); } }
        //public ICommand ChangeWeightCommand { get { return new DelegateCommand(ChangeWeight); } }
        //public ICommand ChangeEyesCommand { get { return new DelegateCommand(ChangeEyes); } }
        //public ICommand ChangeHairCommand { get { return new DelegateCommand(ChangeHair); } }
        //public ICommand ChangeHomelandCommand { get { return new DelegateCommand(ChangeHomeland); } }
        ////public ICommand ChangeLanguagesCommand { get { return new DelegateCommand(ChangeLanguages); } }
        //public ICommand ChangeExperiencePointsCommand { get { return new DelegateCommand(ChangeExperiencePoints); } }

        // This block is temporary.  In the future we will have a dialog box for the user to enter the new value to assign.
        // todo: add additional for every acessor above
        //public void ChangeStrength() { Strength = "Over 9000!"; }
        //public void ChangeDexterity() { Dexterity = "Over 9000!"; }
        //public void ChangeConstitution() { Constitution = "Over 9000!"; }
        //public void ChangeIntelligence() { Intelligence = "Over 9000!"; }
        //public void ChangeWisdom() { Wisdom = "Over 9000!"; }
        //public void ChangeCharisma() { Charisma = "Over 9000!"; }
        //public void ChangeCharacterName() { CharacterName = "Over 9000!"; }
        //public void ChangePlayerName() { PlayerName = "Over 9000!"; }
        //public void ChangeRace() { Race = "Over 9000!"; }
        //public void ChangeSize() { Size = "Over 9000!"; }
        //public void ChangeAlignment() { Alignment = "Over 9000!"; }
        //public void ChangeAge() { Age = "Over 9000!"; }
        //public void ChangeDeity() { Deity = "Over 9000!"; }
        //public void ChangeGender() { Gender = "Over 9000!"; }
        //public void ChangeHeight() { Height = "Over 9000!"; }
        //public void ChangeWeight() { Weight = "Over 9000!"; }
        //public void ChangeEyes() { Eyes = "Over 9000!"; }
        //public void ChangeHair() { Hair = "Over 9000!"; }
        //public void ChangeHomeland() { Homeland = "Over 9000!"; }
        ////public void ChangeLanguages() { Languages = "Over 9000!"; }
        //public void ChangeExperiencePoints() { ExperiencePoints = "Over 9000!"; }


        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            RaisePropertyChangedEvent("CharacterName");
            RaisePropertyChangedEvent("PlayerName");
            RaisePropertyChangedEvent("Race");
            RaisePropertyChangedEvent("Size");
            RaisePropertyChangedEvent("Alignment");
            RaisePropertyChangedEvent("Age");
            RaisePropertyChangedEvent("Diety");
            RaisePropertyChangedEvent("Gender");
            RaisePropertyChangedEvent("Height");
            RaisePropertyChangedEvent("Weight");
            RaisePropertyChangedEvent("Eyes");
            RaisePropertyChangedEvent("Hair");
            RaisePropertyChangedEvent("Homeland");
            RaisePropertyChangedEvent("Strength");
            RaisePropertyChangedEvent("Dexterity");
            RaisePropertyChangedEvent("Constitution");
            RaisePropertyChangedEvent("Intelligence");
            RaisePropertyChangedEvent("Wisdom");
            RaisePropertyChangedEvent("Charisma");
            RaisePropertyChangedEvent("Common");
            RaisePropertyChangedEvent("CharacterName");
            RaisePropertyChangedEvent("Dwarven");
            RaisePropertyChangedEvent("ExperiencePoints");
            RaisePropertyChangedEvent("Barbarian");
            RaisePropertyChangedEvent("Bard");
            RaisePropertyChangedEvent("Cleric");
            RaisePropertyChangedEvent("Druid");
            RaisePropertyChangedEvent("Fighter");
            RaisePropertyChangedEvent("Ranger");
            RaisePropertyChangedEvent("Sorcerer");
            RaisePropertyChangedEvent("Wizard");
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        
    }
}
