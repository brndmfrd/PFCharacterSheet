using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleTools;

namespace ActiveCharacter
{
    /// <summary>
    /// This class acts as the container, the model, for all the rest of the project to refrence.
    /// Data is stored from the disk to this class to load a new character.
    /// Data is stored to the disk from this class to save/update a character.
    /// Data is filled in this class when creating a new character.
    /// Only the foundational data needs to be stored here. For instance, we would store the number of ranks in a skill, but no the total value.
    /// This is because the total value can be derived from other values (e.g. strength mod + ranks in swim = total swim check). This saves us from 
    /// redundant data and less room for inconsistant data. 
    /// </summary>
    public static class Character
    {
        #region Character Information
        /// <summary>
        /// The player chosen characteristics of the character.
        /// </summary>        
        public static BasicInformation Information = new BasicInformation();

        /// <summary>
        /// Player chosen race of the given character.
        /// </summary>
        public static CharacterRace Race = new CharacterRace();

        /// <summary>
        /// Player rolled ability scores
        /// </summary>
        public static Abilities AbilityScores = new Abilities();
        #endregion Character Information
        
        #region Languages
        /// <summary>
        /// Player chosen languages the character can speak fluently.
        /// </summary>
        public static List<string> Languages = new List<string>() { };
        #endregion Languages

        #region Classes
        /// <summary>
        /// Player chosen classes and associated levels.
        /// </summary>
        public static IDictionary<string, CharacterClass> Classes = new Dictionary<string, CharacterClass>() { };
        #endregion Classes

        #region Gear
        /// <summary>
        /// The stuff you carry or have equipped.
        /// </summary>
        public static IDictionary<string, Item> Gear = new Dictionary<string, Item>(){};
        #endregion Gear

        #region Skills
        /// <summary>
        /// Player chosen skills and associated rank points.
        /// </summary>
        public static IDictionary<string, Skill> Skills = new Dictionary<string, Skill>(){ };
        #endregion Skills

        /// <summary>
        /// Player chosen Feats added to this character
        /// </summary>
        public static IDictionary<string, Feat> Feats = new Dictionary<string, Feat>() { };

        /// <summary>
        /// Player chosen Spells added to this character
        /// </summary>       
        public static IDictionary<string, Spell> Spells = new Dictionary<string, Spell>() { };
    }   
}
