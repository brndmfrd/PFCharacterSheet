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
        #endregion

        #region combat
        public static IDictionary<string, string> Combat = new Dictionary<string, string>(){
            {"hitPoints", "0"},
            {"initiative", "0"},
            {"armorClass", "0"},
            {"fortitudeSave", "0"},
            {"reflexSave", "0"},
            {"willSave", "0"},
            {"baseAttackBonus", "0"},
            {"combatManeuverBonus", "0"},
            {"combatManeuverDefence", "0"},
            {"statusEffect", "0"},
            {"encumbrance", "0"},
            {"movement_combat", "0"}
        };


        public static string hitPoints = "noval";
        public static string initiative = "noval"; // misc modifiers
        public static string armorClass = "noval"; // misc modifiers
        public static string fortitudeSave = "noval"; // misc modifiers
        public static string reflexSave = "noval"; // misc modifiers
        public static string willSave = "noval";  // misc modifiers
        public static string baseAttackBonus = "noval"; // can probably remove this - derived from classes
        public static string combatManeuverBonus = "noval"; // bonus from feats & misc
        public static string combatManeuverDefence = "noval"; // bonus from feats & misc
        public static string statusEffect = "noval"; 
        public static string encumbrance = "noval"; // can probably remove this - derived from weight of all held gear
        public static string movement_combat = "noval"; // can probably remove this - derived from weight of all held gear
        public static string spellResistance = "noval"; 
        #endregion

        #region gear_wealth
        // --- gear and wealth ---
        public static string gold = "noval";
        public static string gear = "noval";
        public static string equipment = "noval";
        public static string weapons = "noval";
        public static string armor = "noval";
        #endregion

        #region skills
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
        #endregion

        // --- Feats ---

        // --- Spells ---


    }
}
