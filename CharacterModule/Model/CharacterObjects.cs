﻿using CharacterDataObjects;
using System.Collections.ObjectModel;
using SharedResources.EventHandlers;

namespace CharacterModule.Model
{
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;
        //public string _bonus;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
        //public string Bonus { get { return _bonus; } set { _bonus = value; RaisePropertyChangedEvent("Bonus"); } }
    }
    
    // Stage data to be displayed for the character module here 
    // Unify objects with a "Name" and a "Value" assumed by the UI to display titles and values 
    // of any object we wish to display.
    public static class CharacterObjects
    {
        public static ObservableCollection<DisplayObject> BasicInfoObjects
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach (var elem in MyCharacter.BasicCharacterInfo)
                {
                    tmp.Add(new DisplayObject { Name = elem.Key, Value = elem.Value });
                }

                return tmp;
            }
        }

        public static ObservableCollection<DisplayObject> Languages
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach (var elem in MyCharacter.Languages)
                {
                    tmp.Add(new DisplayObject { Name = "Language", Value = elem });
                }

                return tmp;
            }
        }

        public static ObservableCollection<DisplayObject> BlankSpace = new ObservableCollection<DisplayObject>() { new DisplayObject { Name = " ", Value = " " } };

        public static ObservableCollection<DisplayObject> AbilityScores
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach(var elem in MyCharacter.AbilityScores)
                {
                    tmp.Add(new DisplayObject { Name = elem.Key, Value = string.Format($"{elem.Value.Value.ToString()} +{elem.Value.AbilityModifier.ToString()}")});
                }

                return tmp;
            } 
        }

        public static ObservableCollection<DisplayObject> JobClasses
        {
            get
            {
                var tmp = new ObservableCollection<DisplayObject>();

                foreach (var elem in MyCharacter.JobClasses)
                {
                    tmp.Add(new DisplayObject { Name = elem.Key, Value = elem.Value.Level.ToString() });
                }

                return tmp;
            }
        }
    }


}
