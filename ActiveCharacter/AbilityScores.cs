﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Abilities : MyPropertyChangedEventHandler
    {
        public string AbilityName { get; set; }
        public ushort Value { get; set; }
    }
}
