using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects;
using System.Collections.ObjectModel;
using ModuleTools;
using CharacterDataObjects.CharacterDataConstants;

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
            new DisplayObject { Name = Constants.Hitpoints, Value = MyCharacter.HP.Total.ToString() },

            new DisplayObject { Name = Constants.FullMeleeAttack, Value = GetFullAttackValues() },

            new DisplayObject { Name = Constants.BullRush, Value = MyCharacter.Cmb.ToString()},
            new DisplayObject { Name = Constants.Trip, Value = MyCharacter.Cmb.ToString() },
            new DisplayObject { Name = Constants.Disarm, Value = MyCharacter.Cmb.ToString() },
            new DisplayObject { Name = Constants.Sunder, Value = MyCharacter.Cmb.ToString() },
            new DisplayObject { Name = Constants.Reposition, Value = MyCharacter.Cmb.ToString() },

            new DisplayObject { Name = Constants.Fortitude, Value = MyCharacter.SavingThrows[Constants.Fortitude].Total.ToString()},
            new DisplayObject { Name = Constants.Reflex, Value = MyCharacter.SavingThrows[Constants.Reflex].Total.ToString() },
            new DisplayObject { Name = Constants.Will, Value = MyCharacter.SavingThrows[Constants.Will].Total.ToString() },
        };
        
        // The object that is currently selected in the view 
        public static DisplayObject CurrentSelectedObject = new DisplayObject();

        private static string GetFullAttackValues()
        {
            var attacks = new List<int>();

            // derive bonus attacks for high bab score
            var babValue = MyCharacter.Bab;

            do
            {
                attacks.Add(babValue);
                babValue -= 5;
            }
            while (babValue > 5);

            // Check if we apply st or dex to attack
            var abilityBonus = MyCharacter.AbilityScores[Constants.Strength].AbilityModifier;
            foreach (var feat in MyCharacter.Feats)
            {
                if(feat.Name == Constants.WeaponFiness)
                {
                    abilityBonus = MyCharacter.AbilityScores[Constants.Dextarity].AbilityModifier;
                    break;
                }
            }

            // Appply ability bonus
            for(int i = 0; i < attacks.Count; i++)
            {
                attacks[i] += abilityBonus;
            }

            // Check for character enchantments

            // Check for equipped weapon enchantments
        }

    }
}
