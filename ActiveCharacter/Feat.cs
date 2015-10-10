using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Feat
    {
        public string fetName;
        public string description;
        public string featTraitAbility;     // indicate if this is a 'feat', 'racial trait', or 'ability' as granted by a spell or class
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
        // +2, when grappling
    }
}
