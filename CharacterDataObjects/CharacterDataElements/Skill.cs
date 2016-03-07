using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Skill
    {
        #region Private
        private string skillName;
        private ushort ranks;
        private string description;
        private string associatedAbility;
        private bool armorCheckPenalty;
        private int totalBonus;
        private Dictionary<string, ushort> miscModifiers;
        #endregion Private

        #region Constructor
        public Skill(string _abilityModifier)
        {
            associatedAbility = _abilityModifier;
            miscModifiers = new Dictionary<string, ushort>();
        }
        #endregion Constructor

        #region Properties
        /// <summary>
        /// The name of the skill
        /// </summary>
        public string Name { get { return skillName; } set { skillName = value; } }

        /// <summary>
        /// The number of ranks the player has added to skill
        /// </summary>
        public ushort Ranks { get { return ranks; } set { ranks = value;  } }

        /// <summary>
        /// Short description of the skill
        /// </summary>
        public string Description { get { return description; } set { description = value;  } }

        /// <summary>
        /// Does the armor check penalty apply to this skill
        /// </summary>
        public bool ArmorCheckPenalty { get { return armorCheckPenalty; } set { armorCheckPenalty = value; } }
        
        /// <summary>
        /// Does the armor check penalty apply to this skill
        /// </summary>
        public Dictionary<string, ushort> MiscModifiers { get { return miscModifiers; } set { miscModifiers = value; } }
        #endregion Properties

        #region Public Methods
        public int GetTotalValue()
        {
            var retval = int.MinValue;

            retval = ranks;
            retval += MyCharacter.AbilityScores[associatedAbility].AbilityModifier;
            foreach(var elem in miscModifiers)
            {
                retval += elem.Value;
            }

            return retval;

        }
        #endregion Public Methods
    }
}
