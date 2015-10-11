using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Feat : MyPropertyChangedEventHandler
    {
        public string _name;
        public string _description;
        public string _featTraitAbility;     
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

        /// <summary>
        /// 
        /// </summary>
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get { return _description; } set { _description = value; RaisePropertyChanged("Description"); } }
        /// <summary>
        /// indicate if this is a 'feat', 'racial trait', or 'ability' as granted by a spell or class
        /// </summary>
        public string FeatTraitAbility { get { return _featTraitAbility; } set { _featTraitAbility = value; RaisePropertyChanged("FeatTraitAbility"); } }
    }
}
