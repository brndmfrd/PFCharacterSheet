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
        public static IDictionary<string, string> Information = new Dictionary<string, string>(){
            {"ID", "0"},
            {"characterName", "0"},
            {"playerName", "0"},
            {"race", "0"},
            {"size", "0"},
            {"alignment", "0"},
            {"age", "0"},
            {"deity", "0"},
            {"gender", "0"},
            {"height", "0"},
            {"weight", "0"},
            {"eyes", "0"},
            {"hair", "0"},
            {"homeland", "0"},
            {"strength", "0"},
            {"dexterity", "0"},
            {"constitution", "0"},
            {"intelligence", "0"},
            {"wisdom", "0"},
            {"charisma", "0"},
            {"common", "0"},
            {"dwarven", "0"},
            {"draconic", "0"},
            {"experiencePoints", "0"},
            {"Barbarian", "0"},
            {"Bard", "0"},
            {"Cleric", "0"},
            {"Druid", "0"},
            {"Fighter", "0"},
            {"Ranger", "0"},
            {"Sorcerer", "0"},
            {"Wizard", "0"}
        };
        
        public static int ID = 0;
        public static string characterName = "noval";
        public static string playerName = "noval";
        public static string race = "noval";
        public static string jobclass = "noval";
        public static string size = "noval";
        public static string alignment = "noval";
        public static string age = "noval";
        public static string deity = "noval";
        public static string gender = "noval";
        public static string height = "noval";
        public static string weight = "noval";
        public static string eyes = "noval";
        public static string hair = "noval";
        public static string homeland = "noval";
        public static string strength = "0";
        public static string dexterity = "0";
        public static string constitution = "0";
        public static string intelligence = "0";
        public static string wisdom = "0";
        public static string charisma = "0";
        public static string languages = "noval";
        public static string experiencePoints = "noval";
        // public static List<string> classes = null;       TBD
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
        public static string initiative = "noval";
        public static string armorClass = "noval";
        public static string fortitudeSave = "noval";
        public static string reflexSave = "noval";
        public static string willSave = "noval";
        public static string baseAttackBonus = "noval";
        public static string combatManeuverBonus = "noval";
        public static string combatManeuverDefence = "noval";
        public static string statusEffect = "noval";
        public static string encumbrance = "noval";
        public static string movement_combat = "noval";
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

        public static int acrobatics;
        public static int appraise;
        public static int bluff;
        public static int climb;
        public static int craft;
        public static int diplomacy;
        public static int disableDevice;
        public static int disguise;
        public static int escapeArtist;
        public static int fly;
        public static int handleAnimal;
        public static int heal;
        public static int intimidate;
        public static int knowledgeArcana;
        public static int knowledgeDungeoneering;
        public static int knowledgeEngineering;
        public static int knowledgeGeography;
        public static int knowledgeHistory;
        public static int knowledgeLocal;
        public static int knowledgeNature;
        public static int knowledgeNobility;
        public static int knowledgePlanes;
        public static int knowledgeReligion;
        public static int linguistics;
        public static int perception;
        public static int perform;
        public static int profession;
        public static int ride;
        public static int senseMotive;
        public static int sleightOfHand;
        public static int spellcraft;
        public static int stealth;
        public static int survival;
        public static int swim;
        public static int useMagicDevice;

        #endregion

        // --- Feats ---

        // --- Spells ---


    }
}
