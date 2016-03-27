using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;

namespace SkillsModule.Model
{
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;
        public string _result;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
        public string Result { get { return _result; } set { _result = value; RaisePropertyChangedEvent("Result"); } }
    }

    public class SkillObjects
    {
        private static ObservableCollection<DisplayObject> displayObjects = new ObservableCollection<DisplayObject>();

        public static ObservableCollection<DisplayObject> DisplayObjects
        {
            get
            {
                return displayObjects;
            }
        }

        // The object that is currently selected in the view 
        public static DisplayObject CurrentSelectedObject = new DisplayObject();

        #region Private Methods
        private static void RebuildDisplayObjects()
        {
            displayObjects.Clear();
            foreach (var elem in MyCharacter.Skills)
            {
                displayObjects.Add(new DisplayObject { Name = elem.Key, Value = elem.Value.TotalValue.ToString() });
            }
        }

        public static void UpdateDisplayObjects()
        {
            // Skills were added or removed; reflect this.
            if (displayObjects.Count != MyCharacter.Skills.Count)
            {
                RebuildDisplayObjects();
                return;
            }

            // Skills were not added or removed; check if values changed.
            foreach (var elem in displayObjects)
            {
                if (!MyCharacter.Skills.ContainsKey(elem.Name))
                {
                    // Mismatch!
                    RebuildDisplayObjects();
                    return;
                }

                elem.Value = MyCharacter.Skills[elem.Name].TotalValue.ToString();
            }
        }
        #endregion Private Methods

    }
}
