using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Race : MyPropertyChangedEventHandler
    {
        public string _name;
        public string _description;

        /// <summary>
        /// 
        /// </summary>
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get { return _description; } set { _description = value; RaisePropertyChanged("Description"); } }
    }
}
