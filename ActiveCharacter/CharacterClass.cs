using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class CharacterClass : MyPropertyChangedEventHandler
    {
        public string _name;
        public ushort _level;
        public ushort _hitdie;
        public ushort _skillRanksPerLevel;
        public uint[] _babProgression
            = new uint[20];
        public uint[] _fortProgression
            = new uint[20];
        public uint[] _refProgression
            = new uint[20];
        public uint[] _willProgression
            = new uint[20];
        public uint[,] _spellsPerDay
            = new uint[9, 20];
        public uint[,] _spellsKnown
            = new uint[9, 20];

        /// <summary>
        /// Name of the class
        /// </summary>
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        /// <summary>
        /// Levels achieved in this class
        /// </summary>
        public ushort Level { get { return _level; } set { _level = value; RaisePropertyChanged("Level"); } }
        /// <summary>
        /// The hit die associated with this class
        /// </summary>
        public ushort Hitdie { get { return _hitdie; } set { _hitdie = value; RaisePropertyChanged("Hitdie"); } }
        /// <summary>
        /// Number of skill points the class awards at each level
        /// </summary>
        public ushort SkillRanksPerLevel { get { return _skillRanksPerLevel; } set { _skillRanksPerLevel = value; RaisePropertyChanged("SkillRanksPerLevel"); } }
        /// <summary>
        /// Base hit points at each class level
        /// </summary>
        public uint[] BabProgression { get { return _babProgression; } set { _babProgression = value; RaisePropertyChanged("BabProgression"); } }
        /// <summary>
        /// Base fortitude saves of each class level
        /// </summary>
        public uint[] FortProgression { get { return _fortProgression; } set { _fortProgression = value; RaisePropertyChanged("FortProgression"); } }
        /// <summary>
        /// Base reflex saves of each class level
        /// </summary>
        public uint[] RefProgression { get { return _refProgression; } set { _refProgression = value; RaisePropertyChanged("RefProgression"); } }
        /// <summary>
        /// Base will saves of each class level
        /// </summary>
        public uint[] WillProgression { get { return _willProgression; } set { _willProgression = value; RaisePropertyChanged("WillProgression"); } }
        /// <summary>
        /// Base number spells per day granted by the given class
        /// /// </summary>
        public uint[,] SpellsPerDay { get { return _spellsPerDay; } set { _spellsPerDay = value; RaisePropertyChanged("SpellsPerDay"); } }
        /// <summary>
        /// Base number of spells known at each level as granted by the given class
        /// </summary>
        public uint[,] SpellsKnown { get { return _spellsKnown; } set { _spellsKnown = value; RaisePropertyChanged("SpellsKnown"); } }
    }
}
