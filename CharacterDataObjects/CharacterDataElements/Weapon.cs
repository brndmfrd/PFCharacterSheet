using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Weapon
    {
        private string weaponName;
        private int weaponBonusAttack;    // bonus, like masterwork
        private int weaponBonusDamage;    // bonus, like +5 damage enchantment
        private short nCritDice;
        private short critDie;
        private Enums.WeaponType type;      // slash, peirce, bludgeon
        private int range;
        private int ammunition;
        private short nDamageDice;
        private short damageDie;
        private string description;
        private List<string> specialProperties = new List<string>();    // masterwork, enchanted, cursed, etc
        private int weight;
        private string attackBonusAbility;  // ability score associated with an attack with weapon
        private string damageBonusAbility;  // ability score associated with the damage of this weapon

        #region Constructor
        /// <summary>
        /// A single weapon or collection of the same weapon e.g. shuricans or arrows
        /// </summary>
        /// <param name="_attackAbility">The ability name whos modifier value will be associated with attacks from this weapon, initially</param>
        /// <param name="_damageAbility">The ability name whos modifier value will be associated with damage from this weapon, initially</param>
        public Weapon(string _attackAbility, string _damageAbility)
        {
            attackBonusAbility = _attackAbility;
            damageBonusAbility = _damageAbility;
        }
        #endregion Constructor


        //todo: accessors
        public string WeaponName { get { return weaponName; } set { weaponName = value; } }

        //todo: determine if total bonus (attk&dmg) should be here or do this calculation in 'Attack' class
    }
}
