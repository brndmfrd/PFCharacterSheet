using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Skill : MyPropertyChangedEventHandler
    {
        private string _name;                 
        private ushort _ranks;                
        private string _description;          
        private bool _untrained;              
        private string _ability;              
        private bool _armorCheckPenalty;      

        /// <summary>
        /// The name of the skill
        /// </summary>
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        /// <summary>
        /// The number of ranks the player has added to skill
        /// </summary>
        public ushort Ranks { get { return _ranks; } set { _ranks = value; RaisePropertyChanged("Ranks"); } }
        /// <summary>
        /// Short description of the skill
        /// </summary>
        public string Description { get { return _description; } set { _description = value; RaisePropertyChanged("Description"); } }
        /// <summary>
        /// Can this skill be used untrained
        /// </summary>
        public bool Untrained { get { return _untrained; } set { _untrained = value; RaisePropertyChanged("Untrained"); } }
        /// <summary>
        /// The ablility score modified associated with the skill
        /// </summary>
        public string Ability { get { return _ability; } set { _ability = value; RaisePropertyChanged("Ability"); } }
        /// <summary>
        /// Does the armor check penalty apply to this skill
        /// </summary>
        public bool ArmorCheckPenalty { get { return _armorCheckPenalty; } set { _armorCheckPenalty = value; RaisePropertyChanged("ArmorCheckPenalty"); } }


    }
}
