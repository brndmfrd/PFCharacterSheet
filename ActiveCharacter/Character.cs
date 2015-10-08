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
        // Characteristics
        // todo: add more languages and classes
        public static IDictionary<string, string> Information = new Dictionary<string, string>(){
            {Constants.characterName, "NONAME"},
            {Constants.playerName, "NONAME"},
            {Constants.race, "NONE"},
            {Constants.size, "MEDIUM"},
            {Constants.alignment, "NEUTRAL"},
            {Constants.age, "0"},
            {Constants.deity, "NONE"},
            {Constants.gender, "NONE"},
            {Constants.height, "0 METERS"},
            {Constants.weight, "0 KILOGRAMS"},
            {Constants.eyes, "NONE"},
            {Constants.hair, "NONE"},
            {Constants.homeland, "NONE"},
            {Constants.strength, "0"},
            {Constants.dexterity, "0"},
            {Constants.constitution, "0"},
            {Constants.intelligence, "0"},
            {Constants.wisdom, "0"},
            {Constants.charisma, "0"},
            {Constants.common, "YES"},
            {Constants.dwarven, "NO"},
            {Constants.draconic, "NO"},
            {Constants.experiencePoints, "0"},
            {Constants.barbarian, "0"},
            {Constants.bard, "0"},
            {Constants.cleric, "0"},
            {Constants.druid, "0"},
            {Constants.fighter, "0"},
            {Constants.ranger, "0"},
            {Constants.sorcerer, "0"},
            {Constants.wizard, "0"}
        };
        #endregion Character Information

        #region Combat
        /// <summary>
        /// The base values of combat.
        /// What the values represent:
        ///     hitPoints: max hit point value
        ///     initiative: misc modifiers adding to initiative score
        ///     armorClass: misc modifiers adding to the characters armor class
        ///     fortitudeSave: misc modifiers adding to the characters fortitude score
        ///     reflexSave: misc modifiers adding to the characters reflex score
        ///     willSave: misc modifiers adding to the characters will score
        ///     combatManeuverBonus: total bonus values from feats & misc
        ///     combatManeuverDefence: total bonus values from feats & misc
        ///     statusEffect: The list of currently active status effects effecting the character
        ///     spellResistance: The characters total spell resistance
        /// </summary>
        public static IDictionary<string, string> Combat = new Dictionary<string, string>(){
            {Constants.hitPoints, "0"},
            {Constants.initiative, "0"},
            {Constants.armorClass, "0"},
            {Constants.fortitudeSave, "0"},
            {Constants.reflexSave, "0"},
            {Constants.willSave, "0"},
            {Constants.combatManeuverBonus, "0"},
            {Constants.combatManeuverDefence, "0"},
            {Constants.statusEffect, "0"},
            {Constants.spellResistance, "0"}
        };
        #endregion Combat

        #region Gear
        /// <summary>
        /// Collection of gold, armor, weapons, and all other possessions.
        /// TODO: concider building from a generic list, a heirarchy of items
        ///     items: name, amount, weight, value, description
        ///         goods: description
        ///         gear: size, special properties
        ///             armor: armor properties
        ///             weapon: weapon properties
        ///         wearable magic: items slot, stat bonus
        ///             ring: ring properties
        ///             belt: belt properties
        ///             ...
        ///         magic tools: number of charges, spell emulated
        ///             wand: special properties
        ///             scroll: special properties
        ///             wonderous item: special properties
        /// </summary>
        public static IDictionary<string, string> Gear = new Dictionary<string, string>(){
        };


        public static string gold = "noval";
        public static string gear = "noval";
        public static string equipment = "noval";
        public static string weapons = "noval";
        public static string armor = "noval";
        #endregion Gear

        #region Skills
        // --- Skills ---
        // These represent ranks and misc bonus/penalty
        public static IDictionary<string, int> Skills = new Dictionary<string, int>(){
            {Constants.acrobatics,0},
            {Constants.appraise,0},
            {Constants.bluff,0},
            {Constants.climb,0},
            {Constants.craft,0},
            {Constants.diplomacy,0},
            {Constants.disableDevice,0},
            {Constants.disguise,0},
            {Constants.escapeArtist,0},
            {Constants.fly,0},
            {Constants.handleAnimal,0},
            {Constants.heal,0},
            {Constants.intimidate,0},
            {Constants.knowledgeArcana,0},
            {Constants.knowledgeDungeoneering,0},
            {Constants.knowledgeEngineering,0},
            {Constants.knowledgeGeography,0},
            {Constants.knowledgeHistory,0},
            {Constants.knowledgeLocal,0},
            {Constants.knowledgeNature,0},
            {Constants.knowledgeNobility,0},
            {Constants.knowledgePlanes,0},
            {Constants.knowledgeReligion,0},
            {Constants.linguistics,0},
            {Constants.perception,0},
            {Constants.perform,0},
            {Constants.profession,0},
            {Constants.ride,0},
            {Constants.senseMotive,0},
            {Constants.sleightOfHand,0},
            {Constants.spellcraft,0},
            {Constants.stealth,0},
            {Constants.survival,0},
            {Constants.swim,0},
            {Constants.useMagicDevice,0}
        };
        #endregion Skills

        // --- Feats ---

        // --- Spells ---


    }   
}
