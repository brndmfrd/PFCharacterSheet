using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;

namespace FeatsModule.Model
{

    public class DisplayObject : ObservableObject
    {
        public string _name;
        //public string _value;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        //public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
    }

    public class FeatObjects
    {
        public static ObservableCollection<DisplayObject> Feats
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach (var elem in MyCharacter.Feats)
                {
                    tmp.Add(new DisplayObject { Name = elem.Name});
                }

                return tmp;
            }
        }
    }
}
