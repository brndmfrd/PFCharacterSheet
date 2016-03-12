using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Spell
    {
        private string name;
        private string description;
        private short level;

        public string SpellName { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public short Level { get { return level; } set { level = value; } }
    }
}
