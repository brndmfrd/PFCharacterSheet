using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class JobClass
    {
        private int level;
        private int babProgression = 0; // slow, medium, fast -- figure out later

        public int Level {
            get { return level; }
            set { level = value; }
        }
        public int BaseAttackBonus {
            get { return GetBaseAttackBonus(level, babProgression); }
        }


        private int GetBaseAttackBonus(int lvl, int prog)
        {
            var bab = 0;

            // slow
            if (prog == 0)
            {
                bab = (int)Math.Floor(lvl * 0.5);
            }

            // medium
            if (prog == 1)
            {
                bab = (int)Math.Floor(lvl * 0.75);

            }

            // medium
            if (prog == 1)
            {
                bab = lvl;

            }

            return bab;
        }
    }
}
