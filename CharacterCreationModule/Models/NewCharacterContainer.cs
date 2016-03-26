using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using CharacterDataObjects;
using SharedResources.EventHandlers;

namespace CharacterCreationModule.Models
{
    public class DisplayObject : ObservableObject
    {
        public string _name;
        public string _value;

        public string Name { get { return _name; } set { _name = value; RaisePropertyChangedEvent("Name"); } }
        public string Value { get { return _value; } set { _value = value; RaisePropertyChangedEvent("Value"); } }
    }

    public static class NewCharacterContainer
    {
        #region Character Information
        /// <summary>
        /// The player chosen characteristics of the character.
        /// </summary>  
        public static ObservableCollection<DisplayObject> Information = InitInformation(MyCharacter.BasicCharacterInfo.Select(x=>x.Key));

        /// <summary>
        /// Player rolled ability scores
        /// </summary>
        public static ObservableCollection<DisplayObject> AbilityScores = InitInformation(MyCharacter.AbilityScores.Select(x => x.Key));
        #endregion Character Information

        #region Languages
        /// <summary>
        /// Player chosen languages the character can speak fluently.
        /// </summary>
        public static ObservableCollection<DisplayObject> Languages = new ObservableCollection<DisplayObject>();
        #endregion Languages

        #region Race
        /// <summary>
        /// Player chosen languages the character can speak fluently.
        /// </summary>
        public static ObservableCollection<DisplayObject> Race = new ObservableCollection<DisplayObject>();
        #endregion Race

        #region Classes
        /// <summary>
        /// Player chosen classes and associated levels.
        /// </summary>
        public static ObservableCollection<DisplayObject> Classes = new ObservableCollection<DisplayObject>() { };
        #endregion Classes

        #region Gear
        /// <summary>
        /// The stuff you carry or have equipped.
        /// </summary>
        public static ObservableCollection<DisplayObject> Gear = new ObservableCollection<DisplayObject>() { };
        public static ObservableCollection<DisplayObject> Weapons = new ObservableCollection<DisplayObject>() { };
        public static ObservableCollection<DisplayObject> Armor = new ObservableCollection<DisplayObject>() { };
        public static ObservableCollection<DisplayObject> Wonderous = new ObservableCollection<DisplayObject>() { };
        #endregion Gear

        #region Skills
        /// <summary>
        /// Player chosen skills and associated rank points.
        /// </summary>
        public static ObservableCollection<DisplayObject> Skills = new ObservableCollection<DisplayObject>() { };
        #endregion Skills

        /// <summary>
        /// Player chosen Feats added to this character
        /// </summary>
        public static ObservableCollection<DisplayObject> Feats = new ObservableCollection<DisplayObject>() { };

        /// <summary>
        /// Player chosen Spells added to this character
        /// </summary>       
        public static ObservableCollection<DisplayObject> Spells = new ObservableCollection<DisplayObject>() { };




        // Use to initialize existing titles for fields in the collections we already know.
        // e.g. 'Strength' for the 'Ability : Value' pairing.
        // This is not needed for unpaired collections (e.g. 'Languages') because it is just a list of elements. 
        private static ObservableCollection<DisplayObject> InitInformation(IEnumerable<string> dElements)
        {
            var tmp = new ObservableCollection<DisplayObject>();

            foreach (var elem in dElements)
            {
                tmp.Add(new DisplayObject { Name = elem });
            }

            return tmp;
        }
    }
}
