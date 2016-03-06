using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;
using CharacterDataObjects.CharacterDataObjects;

namespace CharacterDataObjects
{
    public class MyCharacter
    {
        public static Dictionary<string, string> BasicCharacterInfo = new Dictionary<string, string>
        {
            {Constants.CharacterName, string.Empty },
            {Constants.PlayerName, string.Empty },
            {Constants.Alignment, string.Empty },
        };

        public static Dictionary<string, AbilityScore> AbilityScores = new Dictionary<string, AbilityScore>
        {
            {Constants.Strength, new AbilityScore()},
            {Constants.Dextarity, new AbilityScore()},
            {Constants.Consistution, new AbilityScore()},
            {Constants.Intelligence , new AbilityScore()},
            {Constants.Wisdom, new AbilityScore() },
            {Constants.Charisma, new AbilityScore()}
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

        private static BaseAttackBonus bab = new BaseAttackBonus();

        private static int Bab
        {
            get { return bab.GetBaseAttackBonus(); }
        }

    }
}
