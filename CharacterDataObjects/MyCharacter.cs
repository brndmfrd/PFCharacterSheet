using System.Collections.Generic;
using CharacterDataObjects.CharacterDataConstants;
using CharacterDataObjects.CharacterDataElements;

namespace CharacterDataObjects
{
    /// <summary>
    /// The primary container for the current, active, character data.
    /// Access to all character data elements is done through this class.
    /// This class does no logic calculation or data processing, it is just the 
    /// container for other objects that may do processing to derive the correct value.
    /// It should be trusted that all data refrenced from these objects is current.
    /// </summary>
    public class MyCharacter
    {

        //todo: separate out the default data assignments from the variables and have them 
        //      assign value at some loading time (app load, new char load?)

        #region Private
        // These private fields are accessed only for their total value. 
        // The values of these fields are completely derived from other values
        // Nothing needs to be assigned to them to be used.
        private static BaseAttackBonus bab = new BaseAttackBonus();
        private static CombatManeuver cmb = new CombatManeuver(Constants.CMB);
        private static CombatManeuver cmd = new CombatManeuver(Constants.CMD);
        #endregion Private

        #region Public
        /// <summary>
        /// Simple character information such as the character's name, alignment, and age.
        /// </summary>
        public static Dictionary<string, string> BasicCharacterInfo = new Dictionary<string, string>
        {            
            {Constants.CharacterName, string.Empty },
            {Constants.PlayerName, string.Empty },
            {Constants.Alignment, string.Empty },
            {Constants.Size, string.Empty },
            {Constants.Age, string.Empty },
            {Constants.Race, string.Empty },
            {Constants.Deity, string.Empty },
            {Constants.Gender, string.Empty },
            {Constants.Height, string.Empty },
            {Constants.Weight, string.Empty },
            {Constants.Eyes, string.Empty },
            {Constants.Hair, string.Empty },
            {Constants.Homeland, string.Empty },
        };

        /// <summary>
        /// This is a list of all of the languages known by the character.
        /// </summary>
        public static List<string> Languages = new List<string>();

        /// <summary>
        /// These are the character's ability scores, accounting for all bonuses and current buffs.
        /// </summary>
        public static Dictionary<string, Ability> AbilityScores = new Dictionary<string, Ability>
        {
            {Constants.Strength, new Ability()},
            {Constants.Dexterity, new Ability()},
            {Constants.Constitution, new Ability()},
            {Constants.Intelligence , new Ability()},
            {Constants.Wisdom, new Ability() },
            {Constants.Charisma, new Ability()}
        };

        /// <summary>
        /// Traits specific to the character's race.
        /// </summary>
        public static RacialTraits Race = new RacialTraits();

        /// <summary>
        /// The size of the character.
        /// </summary>
        public static SizeClass Size = new SizeClass();
        
        /// <summary>
        /// The character's Armor Class score.
        /// </summary>
        public static ArmorClass AC = new ArmorClass();

        /// <summary>
        /// The character's Hit Points, accounting for recent damage and current buffs.
        /// </summary>
        public static HitPoints HP = new HitPoints();

        /// <summary>
        /// How far the character may move under the current conditions. 
        /// </summary>
        public static Movement Speed = new Movement();

        /// <summary>
        /// The containing object for saving throws that takes the ability modifier and
        /// any current buff/debuff into account. 
        /// </summary>
        public static Dictionary<string, Save> SavingThrows = new Dictionary<string, Save>
        {
            {Constants.Fortitude, new Save(Constants.Constitution)},
            {Constants.Reflex, new Save(Constants.Dexterity)},
            {Constants.Will, new Save(Constants.Wisdom)},
        };

        // Spell Resistance?
        // Probably a static refrence named spellResistance of type: SpellResistance
        // Dictionary<Enums.Magic.Something, int>

        /// <summary>
        /// The containing object for all job classes which have levels.
        /// </summary>
        public static Dictionary<string, JobClass> JobClasses = new Dictionary<string, JobClass>();

        /// <summary>
        /// The character's total base attack bonus is a 
        /// completely derived value and is not set externally.
        /// </summary>
        public static int Bab
        {
            get { return bab.GetBaseAttackBonus(); }
        }

        /// <summary>
        /// Add Combat Maneuver Bonus- returns the calculated
        /// value for the character's current bonus.
        /// </summary>
        public static int Cmb
        {
            get { return cmb.GetCombatManeuverValue(); }
        }

        /// <summary>
        /// Add Combat Maneuver Defense- returns the calculated
        /// value for the character's current bonus.
        /// </summary>
        public static int Cmd
        {
            get { return cmd.GetCombatManeuverValue(); }
        }

        /// <summary>
        /// All of the weapons in the character's possession.
        /// </summary>
        public static List<Weapon> Weapons = new List<Weapon>();

        /// <summary>
        /// Any current item that adds to the character's armor class.
        /// </summary>
        public static List<ArmorClassItems> Armor = new List<ArmorClassItems>();

        /// <summary>
        /// The character's current skills.
        /// </summary>
        public static List<Skill> Skills = new List<Skill>();

        /// <summary>
        /// The character's available feats.
        /// </summary>
        public static List<Feat> Feats = new List<Feat>();

        /// <summary>
        /// Miscellaneous items in the character's possession, not including weapons and armor.
        /// </summary>
        public static List<Item> Gear = new List<Item>();

        /// <summary>
        /// The character's current wealth in copper, silver, gold and platinum.
        /// </summary>
        public static Dictionary<Enums.Coins, uint> Money = new Dictionary<Enums.Coins, uint>
        {
            { Enums.Coins.CP, 0 },
            { Enums.Coins.SP, 0 },
            { Enums.Coins.GP, 0 },
            { Enums.Coins.PP, 0 },
        };

        /// <summary>
        /// A list of all of the spells known by the character.
        /// </summary>
        public static List<Spell> Spells = new List<Spell>();

        /// <summary>
        /// The total spells allowed per day for the character.
        /// </summary>
        public static int[] SpellsPerDay = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };     // SpellsPerDay[0] => level 1 spells per day

        /// <summary>
        /// The total number of spells known by the character.
        /// </summary>
        public static int[] SpellsKnown = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };      // SpellsKnown[8] => level 9 spells known 
        #endregion Public


    }
}
