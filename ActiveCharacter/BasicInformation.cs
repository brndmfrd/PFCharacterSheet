using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class BasicInformation //: INotifyPropertyChanged
    {
        public string Key { get; set; }
        public string Value { get; set; }


        //public event PropertyChangedEventHandler PropertyChanged;

        //private void RaisePropertyChanged(string propertyName)
        //{
        //    if (this.PropertyChanged != null)
        //    {
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
