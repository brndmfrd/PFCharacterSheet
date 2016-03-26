using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Item
    {
        private string itemName;
        private int weight;         // yes, an int. Hydrogen would have a negative weight. You know-- like, if a character was carrying a large volume of hydrogen. The way they do. Silly adventurers.
        private string description;
        private List<string> specialProperties = new List<string>();

        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //todo:accessors
    }
}
