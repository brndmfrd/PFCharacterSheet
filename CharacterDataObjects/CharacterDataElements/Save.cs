using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class Save
    {
        public Save(string _abilityScoreName)
        {
            abilityScoreName = _abilityScoreName;
        }

        private string abilityScoreName;
        private int total = 0;
        private int baseSave = 69;
        private int magicModifier = 0;
        private int miscModifier = 0;
        private int tempModifier = 0;

        public int Total { get { return (total = baseSave + AbilityModifier + magicModifier + miscModifier + tempModifier); } }
        public int BaseSave { get { return baseSave; } set { baseSave = value; } }
        public int AbilityModifier { get { return MyCharacter.AbilityScores[abilityScoreName].AbilityModifier; } }
        public int MagicModifier { get { return magicModifier; } set { magicModifier = value; } }
        public int MiscModifier { get { return miscModifier; } set { miscModifier = value; } }
        public int TempModifier { get { return tempModifier; } set { tempModifier = value; } }
    }
}
