using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class CharacterClass : MyPropertyChangedEventHandler
    {
        public string classname;
        public ushort level;
        public ushort hitdie;
        public ushort skillRanksPerLevel;
        public uint[] babProgression 
            = new uint[20];
        public uint[] fortProgression
            = new uint[20];
        public uint[] refProgression 
            = new uint[20];
        public uint[] willProgression 
            = new uint[20];
        public uint[,] spellsPerDay 
            = new uint[9, 20];
        public uint[,] spellsKnown 
            = new uint[9, 20];
    }
}
