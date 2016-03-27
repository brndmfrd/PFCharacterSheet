using System;
using System.Collections.Generic;
using System.Linq;
using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;
using CharacterDataObjects.CharacterDataConstants;

namespace CombatModule.Model
{
    // todo: maybe move this into ModuleTools since it is generic and all modules can use it to customize what they display
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;
        public string _result;

        public Func<string> CustomMethod;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
        public string Result { get { return _result; } set { _result = value; RaisePropertyChangedEvent("Result"); } }
    }
    
    public static class CombatObjects
    {
        /// <summary>
        /// Unified display objects for the combat module
        /// </summary>
        public static ObservableCollection<DisplayObject> displayObjects = new ObservableCollection<DisplayObject>
        {
            new DisplayObject { Name = Constants.Hitpoints, CustomMethod = GetHp },
            
            new DisplayObject { Name = Constants.FullMeleeAttack, CustomMethod = GetFullAttackValues},

            new DisplayObject { Name = Constants.BullRush, CustomMethod = GetCmb},
            new DisplayObject { Name = Constants.Trip, CustomMethod = GetCmb },
            new DisplayObject { Name = Constants.Disarm, CustomMethod = GetCmb },
            new DisplayObject { Name = Constants.Sunder, CustomMethod = GetCmb },
            new DisplayObject { Name = Constants.Reposition, CustomMethod = GetCmb },

            new DisplayObject { Name = Constants.Fortitude, CustomMethod = GetFort },
            new DisplayObject { Name = Constants.Reflex, CustomMethod = GetRef },
            new DisplayObject { Name = Constants.Will, CustomMethod = GetWill },
        };

        public static ObservableCollection<DisplayObject> DisplayObjects
        {
            get
            {
                foreach(var elem in displayObjects)
                {
                    elem.Value = elem.CustomMethod();
                }

                return displayObjects;
            }
        }

        public static string GetCmb()
        {
            return MyCharacter.Cmb.ToString();
        }

        public static string GetHp()
        {
            return MyCharacter.HP.Total.ToString();
        }

        public static string GetFort()
        {
            return MyCharacter.SavingThrows[Constants.Fortitude].Total.ToString();
        }

        public static string GetRef()
        {
            return MyCharacter.SavingThrows[Constants.Reflex].Total.ToString();
        }

        public static string GetWill()
        {
            return MyCharacter.SavingThrows[Constants.Will].Total.ToString();
        }

        // The object that is currently selected in the view 
        public static DisplayObject CurrentSelectedObject = new DisplayObject();

        public static string GetFullAttackValues()
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
                if (feat.Name == Constants.WeaponFinesse)
                {
                    abilityBonus = MyCharacter.AbilityScores[Constants.Dexterity].AbilityModifier;
                    break;
                }
            }

            // Appply ability bonus
            for (int i = 0; i < attacks.Count; i++)
            {
                attacks[i] += abilityBonus;
            }

            // Check for character enchantments

            // Check for equipped weapon enchantments

            var retval = attacks.Select(x => string.Format($"+{x}")).ToArray();
            return string.Join("/", retval);
        }

        public static string GetFullAttackRollValues()
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
                if (feat.Name == Constants.WeaponFinesse)
                {
                    abilityBonus = MyCharacter.AbilityScores[Constants.Dexterity].AbilityModifier;
                    break;
                }
            }

            // Appply ability bonus
            for (int i = 0; i < attacks.Count; i++)
            {
                attacks[i] += abilityBonus;
            }

            var randy = new Random();
            // Appply d20 roll bonus
            for (int i = 0; i < attacks.Count; i++)
            {
                attacks[i] += randy.Next(1, 21);
            }

            // Check for character enchantments

            // Check for equipped weapon enchantments

            var retval = attacks.Select(x => string.Format($"+{x}")).ToArray();
            return string.Join("/", retval);
        }

    }
}
