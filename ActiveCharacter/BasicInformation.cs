using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class BasicInformation : MyPropertyChangedEventHandler
    {
        private string _key;
        private string _value;

        public string Key { get { return _key; } set { _key = value; RaisePropertyChanged("Key"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChanged("Value"); } }
    }
}
