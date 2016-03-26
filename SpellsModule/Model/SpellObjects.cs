using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;

namespace SpellsModule.Model
{
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
    }

    public class SpellObjects
    {
        public static ObservableCollection<DisplayObject> Spells
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach (var elem in MyCharacter.Spells)
                {
                    tmp.Add(new DisplayObject { Name = elem.SpellName });
                }

                return tmp;
            }
        }
    }
}
