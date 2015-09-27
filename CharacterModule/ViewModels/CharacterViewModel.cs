using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using System.Windows.Input;
using ModuleTools;


namespace CharacterModule.ViewModels
{
    public class CharacterViewModel : ObservableObject, INavigationAware
    {
        public string CharacterName
        {
            get { return Character.characterName; }
            set
            {
                Character.characterName = value;
                RaisePropertyChangedEvent("CharacterName");
            }
        }

        public string PlayerName
        {
            get { return Character.playerName; }
            set
            {
                Character.playerName = value;
                RaisePropertyChangedEvent("PlayerName");
            }
        }

        public string Race
        {
            get { return Character.race; }
            set
            {
                Character.race = value;
                RaisePropertyChangedEvent("Race");
            }
        }

        public string Size
        {
            get { return Character.Information["size"]; }
            set { Character.Information["size"] = value; RaisePropertyChangedEvent("Size"); }
        }

        //public string Size
        //{
        //    get { return Character.size; }
        //    set
        //    {
        //        Character.size = value;
        //        RaisePropertyChangedEvent("Size");
        //    }
        //}

        public string Alignment
        {
            get { return Character.alignment; }
            set
            {
                Character.alignment = value;
                RaisePropertyChangedEvent("Alignment");
            }
        }

        public string Age
        {
            get { return Character.age; }
            set
            {
                Character.age = value;
                RaisePropertyChangedEvent("Age");
            }
        }

        public string Deity
        {
            get { return Character.deity; }
            set
            {
                Character.deity = value;
                RaisePropertyChangedEvent("Deity");
            }
        }

        public string Gender
        {
            get { return Character.gender; }
            set
            {
                Character.gender = value;
                RaisePropertyChangedEvent("Gender");
            }
        }

        public string Height
        {
            get { return Character.height; }
            set
            {
                Character.height = value;
                RaisePropertyChangedEvent("Height");
            }
        }

        public string Weight
        {
            get { return Character.weight; }
            set
            {
                Character.weight = value;
                RaisePropertyChangedEvent("Weight");
            }
        }

        public string Eyes
        {
            get { return Character.eyes; }
            set
            {
                Character.eyes = value;
                RaisePropertyChangedEvent("Eyes");
            }
        }

        public string Hair
        {
            get { return Character.hair; }
            set
            {
                Character.hair = value;
                RaisePropertyChangedEvent("Hair");
            }
        }

        public string Homeland
        {
            get { return Character.homeland; }
            set
            {
                Character.homeland = value;
                RaisePropertyChangedEvent("Homeland");
            }
        }

        public string Strength
        {
            get { return Character.strength; }
            set
            {
                Character.strength = value;
                RaisePropertyChangedEvent("Strength");
            }
        }

        public string Dexterity
        {
            get { return Character.dexterity; }
            set
            {
                Character.dexterity = value;
                RaisePropertyChangedEvent("Dexterity");
            }
        }

        public string Constitution
        {
            get { return Character.constitution; }
            set
            {
                Character.constitution = value;
                RaisePropertyChangedEvent("Constitution");
            }
        }

        public string Intelligence
        {
            get { return Character.intelligence; }
            set
            {
                Character.intelligence = value;
                RaisePropertyChangedEvent("Intelligence");
            }
        }

        public string Wisdom
        {
            get { return Character.wisdom; }
            set
            {
                Character.wisdom = value;
                RaisePropertyChangedEvent("Wisdom");
            }
        }

        public string Charisma
        {
            get { return Character.charisma; }
            set
            {
                Character.charisma = value;
                RaisePropertyChangedEvent("Charisma");
            }
        }

        public string Languages
        {
            get { return Character.languages; }
            set
            {
                Character.languages = value;
                RaisePropertyChangedEvent("Languages");
            }
        }

        public string ExperiencePoints
        {
            get { return Character.experiencePoints; }
            set
            {
                Character.experiencePoints = value;
                RaisePropertyChangedEvent("ExperiencePoints");
            }
        }

        // ---------------------------
        public ICommand ChangeStrengthCommand { get { return new DelegateCommand(ChangeStrength); } }
        public ICommand ChangeDexterityCommand { get { return new DelegateCommand(ChangeDexterity); } }
        public ICommand ChangeConstitutionCommand { get { return new DelegateCommand(ChangeConstitution); } }
        public ICommand ChangeIntelligenceCommand { get { return new DelegateCommand(ChangeIntelligence); } }
        public ICommand ChangeWisdomCommand { get { return new DelegateCommand(ChangeWisdom); } }
        public ICommand ChangeCharismaCommand { get { return new DelegateCommand(ChangeCharisma); } }
        public ICommand ChangeCharacterNameCommand { get { return new DelegateCommand(ChangeCharacterName); } }
        public ICommand ChangePlayerNameCommand { get { return new DelegateCommand(ChangePlayerName); } }
        public ICommand ChangeRaceCommand { get { return new DelegateCommand(ChangeRace); } }
        public ICommand ChangeSizeCommand { get { return new DelegateCommand(ChangeSize); } }
        public ICommand ChangeAlignmentCommand { get { return new DelegateCommand(ChangeAlignment); } }
        public ICommand ChangeAgeCommand { get { return new DelegateCommand(ChangeAge); } }
        public ICommand ChangeDeityCommand { get { return new DelegateCommand(ChangeDeity); } }
        public ICommand ChangeGenderCommand { get { return new DelegateCommand(ChangeGender); } }
        public ICommand ChangeHeightCommand { get { return new DelegateCommand(ChangeHeight); } }
        public ICommand ChangeWeightCommand { get { return new DelegateCommand(ChangeWeight); } }
        public ICommand ChangeEyesCommand { get { return new DelegateCommand(ChangeEyes); } }
        public ICommand ChangeHairCommand { get { return new DelegateCommand(ChangeHair); } }
        public ICommand ChangeHomelandCommand { get { return new DelegateCommand(ChangeHomeland); } }
        public ICommand ChangeLanguagesCommand { get { return new DelegateCommand(ChangeLanguages); } }
        public ICommand ChangeExperiencePointsCommand { get { return new DelegateCommand(ChangeExperiencePoints); } }

        // This block is temporary.  In the future we will have a dialog box for the user to enter the new value to assign.
        public void ChangeStrength() { Strength = "Over 9000!"; }
        public void ChangeDexterity() { Dexterity = "Over 9000!"; }
        public void ChangeConstitution() { Constitution = "Over 9000!"; }
        public void ChangeIntelligence() { Intelligence = "Over 9000!"; }
        public void ChangeWisdom() { Wisdom = "Over 9000!"; }
        public void ChangeCharisma() { Charisma = "Over 9000!"; }
        public void ChangeCharacterName() { CharacterName = "Over 9000!"; }
        public void ChangePlayerName() { PlayerName = "Over 9000!"; }
        public void ChangeRace() { Race = "Over 9000!"; }
        public void ChangeSize() { Size = "Over 9000!"; }
        public void ChangeAlignment() { Alignment = "Over 9000!"; }
        public void ChangeAge() { Age = "Over 9000!"; }
        public void ChangeDeity() { Deity = "Over 9000!"; }
        public void ChangeGender() { Gender = "Over 9000!"; }
        public void ChangeHeight() { Height = "Over 9000!"; }
        public void ChangeWeight() { Weight = "Over 9000!"; }
        public void ChangeEyes() { Eyes = "Over 9000!"; }
        public void ChangeHair() { Hair = "Over 9000!"; }
        public void ChangeHomeland() { Homeland = "Over 9000!"; }
        public void ChangeLanguages() { Languages = "Over 9000!"; }
        public void ChangeExperiencePoints() { ExperiencePoints = "Over 9000!"; }


        // ------- needed for INavigationAware -------
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

        
    }
}
