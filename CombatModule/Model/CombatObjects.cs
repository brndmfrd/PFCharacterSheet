using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects;
using System.Collections.ObjectModel;
using ModuleTools;

namespace CombatModule.Model
{
    // todo: maybe move this into ModuleTools since it is generic and all modules can use it to customize what they display
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;
        public string _result;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
        public string Result { get { return _result; } set { _result = value; RaisePropertyChangedEvent("Result"); } }
    }
    
    public static class CombatObjects
    {
        // todo: use a constants file
        // Here we customize the data objects from MyCharacter to suit the needs of just the Combat Module
        // Important to have three values in this combat module, "Name", "Value", and "Result"
        // 'Name' will be the displayed name of the value the user looks at
        // 'Value' will be the displayed current value associated with the element
        // 'Result' is the placeholder value representing the last rolled result, such as the result of a fortitude save
        public static ObservableCollection<DisplayObject> displayObjects = new ObservableCollection<DisplayObject>
        {
            new DisplayObject { Name = "Hit Points", Value = MyCharacter.HP.Total.ToString() },
            new DisplayObject { Name = "Base Attack Bonus", Value = MyCharacter.Bab.ToString() },
            new DisplayObject { Name = "Bull Rush", Value = MyCharacter.AbilityScores["Strength"].Value.ToString() },
            new DisplayObject { Name = "Fortitude", Value = MyCharacter.SavingThrows["Fortitude"].Total.ToString()},
            new DisplayObject { Name = "Reflex", Value = MyCharacter.SavingThrows["Reflex"].Total.ToString() },
            new DisplayObject { Name = "Will", Value = MyCharacter.SavingThrows["Will"].Total.ToString() },
        };
        
        // The object that is currently selected in the view 
        public static DisplayObject CurrentSelectedObject = new DisplayObject();

    }
}
