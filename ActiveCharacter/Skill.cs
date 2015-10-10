using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Skill
    {
        public string name;                 // The name of the skill
        public ushort ranks;                // The number of ranks the player has added to skill
        public string description;          // Short description of the skill
        public bool untrained;              // Can this skill be used untrained
        public string ability;              // The ablility score modified associated with the skill
        public bool armorCheckPenalty;      // Does the armor check penalty apply to this skill
    }
}
