using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;
using SharedResources;

namespace FeatsModule.Model
{

    public class DisplayObject : ObservableObject
    {
        public string _name;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Description { get { return Definitions.Feats[_name]; } }
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
