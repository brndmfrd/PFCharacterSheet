using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using System.Collections.ObjectModel;

namespace CharacterCreationModule.Models
{
    public static class NewCharacterContainer
    {
        #region Character Information
        /// <summary>
        /// The player chosen characteristics of the character.
        /// </summary>        
        public static ObservableCollection<BasicInformation> Information = new ObservableCollection<BasicInformation>();

        /// <summary>
        /// Player rolled ability scores
        /// </summary>
        public static ObservableCollection<Abilities> AbilityScores = new ObservableCollection<Abilities>();
        #endregion Character Information

        #region Languages
        /// <summary>
        /// Player chosen languages the character can speak fluently.
        /// </summary>
        public static ObservableCollection<string> Languages = new ObservableCollection<string>() { };
        #endregion Languages

        #region Classes
        /// <summary>
        /// Player chosen classes and associated levels.
        /// </summary>
        public static ObservableCollection<CharacterClass> Classes = new ObservableCollection<CharacterClass>() { };
        #endregion Classes

        #region Gear
        /// <summary>
        /// The stuff you carry or have equipped.
        /// </summary>
        public static ObservableCollection<Item> Gear = new ObservableCollection<Item>() { };
        #endregion Gear

        #region Skills
        /// <summary>
        /// Player chosen skills and associated rank points.
        /// </summary>
        public static ObservableCollection<Skill> Skills = new ObservableCollection<Skill>() { };
        #endregion Skills

        /// <summary>
        /// Player chosen Feats added to this character
        /// </summary>
        public static ObservableCollection<Feat> Feats = new ObservableCollection<Feat>() { };

        /// <summary>
        /// Player chosen Spells added to this character
        /// </summary>       
        public static ObservableCollection<Spell> Spells = new ObservableCollection<Spell>() { };
    }
}
