//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ModuleTools;

namespace ActiveCharacter
{
    /// <summary>
    /// Container for data objects read from external location.
    /// Data contained is used to derive all other data and does not contain data that could be derived otherwise.
    /// Access to the active character data (loaded character data) comes from this container.
    /// </summary>
    public static class Character
    {
        #region Character Information
        /// <summary>
        /// The player chosen characteristics of the character.
        /// </summary>        
        public static BasicInformation Information = new BasicInformation();

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
