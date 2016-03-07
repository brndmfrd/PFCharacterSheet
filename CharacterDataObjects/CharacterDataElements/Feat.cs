using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Feat
    {
        private string _name;
        private string _description;
        
        //todo: Figure out how to apply benifits of feat to other character properties.

        /// <summary>
        /// 
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get { return _description; } set { _description = value; } }
        
    }
}
