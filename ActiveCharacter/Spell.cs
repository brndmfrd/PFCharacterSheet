using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Spell : MyPropertyChangedEventHandler
    {
        public string name;
        public string decription;
        public string school;
        public string castingTime;
        public string components;
        public string target;
        public string range;
        public string area;
        public string duration;
        public string savingThrow;
        public bool spellResistance;
        public string level;
        public string casterLevel;      // if used to enchant an item
        public string charges;          // if added to an item
        public string aura;             // if as an enchantment
        //todo: add some standard form for penalties & benifits
        // that can be parsed for combat action e.g.
        // <effected property>, <amount>, <duration>
        // Dextarity, 5, 3 (minutes)
        // <status emparted>, <constraints>, <duration>
        // facination, {2d4 HD, person}, 1 (minute)
        // There could be multiple effects, as well.  e.g.
        // Rage => +St, +Dex, +Con
        // Special defence/attack
        // <bonus>, <conditino>
        // +inf AC, vs magic missle (shield negates magic missle)

    }
}
