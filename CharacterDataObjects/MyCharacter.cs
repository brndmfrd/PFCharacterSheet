using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;
using CharacterDataObjects.CharacterDataObjects;

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
        // assign value at some loading time (app load, new char load?)

        #region Private
        private static BaseAttackBonus bab = new BaseAttackBonus();
        #endregion Private

        #region Public
        /// <summary>
        /// Simple character information such as the character's name, race, and age.
        /// </summary>
        public static Dictionary<string, string> BasicCharacterInfo = new Dictionary<string, string>
        {
            {Constants.CharacterName, string.Empty },
            {Constants.PlayerName, string.Empty },
            {Constants.Alignment, string.Empty },
        };

        public static Dictionary<string, Ability> AbilityScores = new Dictionary<string, Ability>
        {
            {Constants.Strength, new Ability()},
            {Constants.Dextarity, new Ability()},
            {Constants.Consistution, new Ability()},
            {Constants.Intelligence , new Ability()},
            {Constants.Wisdom, new Ability() },
            {Constants.Charisma, new Ability()}
        };

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

        public static Dictionary<string, JobClass> JobClasses = new Dictionary<string, JobClass>
        {

        };

        /// <summary>
        /// The character's total base attack bonus is a 
        /// completely derived value and is not set externally.
        /// </summary>
        public static int Bab
        {
            get { return bab.GetBaseAttackBonus(); }
        }
        #endregion Public

    }
}
