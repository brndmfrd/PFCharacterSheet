﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class HitPoints
    {
        private int total;
        private int current;
        private int temporaryHitPoints;
        private int nonleathalDamage;


        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int Current;
        public int TemporaryHitPoints;
        public int NonleathalDamage;
    }
}
