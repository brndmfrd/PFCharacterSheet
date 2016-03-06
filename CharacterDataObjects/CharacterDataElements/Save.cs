using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataObjects
{
    public class Save
    {
        public Save(string _abilityScoreName)
        {
            abilityScoreName = _abilityScoreName;
        }

        private string abilityScoreName;
        private int total;
        private int baseSave;
        private int magicModifier;
        private int miscModifier;
        private int tempModifier;

        public int Total;
        public int BaseSave;
        public int AbilityModifier
        {
            get { return MyCharacter.AbilityScores[abilityScoreName].AbilityModifier; }
        }
        public int MagicModifier;
        public int MiscModifier;
        public int TempModifier;
    }
}
