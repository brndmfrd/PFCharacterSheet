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
        };

        public static List<string> Languages = new List<string>();

        public static Dictionary<string, Ability> AbilityScores = new Dictionary<string, Ability>
        {
            {Constants.Strength, new Ability()},
            {Constants.Dextarity, new Ability()},
            {Constants.Consistution, new Ability()},
            {Constants.Intelligence , new Ability()},
            {Constants.Wisdom, new Ability() },
            {Constants.Charisma, new Ability()}
        };

        public static RacialTraits Race = new RacialTraits();

        public static SizeClass Size = new SizeClass();
        
        public static ArmorClass AC = new ArmorClass();

        public static HitPoints HP = new HitPoints();

        public static Movement Speed = new Movement();

        public static Dictionary<string, Save> SavingThrows = new Dictionary<string, Save>
        {
            {Constants.Fortitude, new Save(Constants.Consistution)},
            {Constants.Reflex, new Save(Constants.Dextarity)},
            {Constants.Will, new Save(Constants.Wisdom)},
        };

        // Spell Resistance?
        // Probably a static refrence named spellResistance of type: SpellResistance
        // Dictionary<Enums.Magic.Something, int>

        public static Dictionary<string, JobClass> JobClasses = new Dictionary<string, JobClass>
        {
            {"Demo Knight", new JobClass { Level = 12 } }
        };

        /// <summary>
        /// The character's total base attack bonus is a 
        /// completely derived value and is not set externally.
        /// </summary>
        public static int Bab
        {
            get { return bab.GetBaseAttackBonus(); }
        }

        public static int Cmb
        {
            get { return cmb.GetCombatManeuverValue(); }
        }

        public static int Cmd
        {
            get { return cmd.GetCombatManeuverValue(); }
        }

        public static List<Weapon> Weapons = new List<Weapon>();

        public static List<ArmorClassItems> Armor = new List<ArmorClassItems>();

        public static List<Skill> Skills = new List<Skill>();

        public static List<Feat> Feats = new List<Feat>();

        public static List<Item> Gear = new List<Item>();

        public static Dictionary<Enums.Coins, uint> Money = new Dictionary<Enums.Coins, uint>
        {
            { Enums.Coins.CP, 0 },
            { Enums.Coins.SP, 0 },
            { Enums.Coins.GP, 0 },
            { Enums.Coins.PP, 0 },
        };

        public static List<Spell> Spells = new List<Spell>();
        public static int[] SpellsPerDay = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };     // SpellsPerDay[0] => level 1 spells per day
        public static int[] SpellsKnown = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };      // SpellsKnown[8] => level 9 spells known 
        #endregion Public


    }
}
