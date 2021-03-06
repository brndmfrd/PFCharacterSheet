﻿using System.Collections.Generic;

namespace ActiveCharacter
{
    /// <summary>
    /// All equipment, items, gear, weapons, armor, possessions
    /// </summary>
    public class Item : MyPropertyChangedEventHandler
    {
        public string _name;            // the name of the type of item e.g. short sword, crowbar, scroll of magic missle
        public double _weight;          // weight per single instance of the item in kg
        public double _value;           // market value in gold; lesser denominations as decimal values
        public string _description;     // short description of refrence info about the item
        public GearSlots _slot;            // item slot used when the item is active/'equipped' (head, left hand, feet). 
        public List<Spell> _spells      // spell, magical ability, aura, CL, number of charges 
            = new List<Spell>();
        public uint _amount;            // number of copies that are 'stacked' with this item
        public bool _unique;            // signifies the item as unique/modified. Do not stack this with 'common' items.
        public ushort _dmgMultiplier;   // The 1 in the 1d8 or the 3 in the 3d6
        public ushort _dmgAmount;       // The 8 in the 1d8 or the 6 in the 3d6
        public ushort _crtMultiplier;   // Critical hit multiplier x1, x2, x3, x4
        public uint _range;             // Effective range the item can be thrown
        public char _dmgType;           // P := peircing, B := Bludgeoning, S := Slashing
        public string _wepFeatures;     // Reach, nonleathal, trip, disarm, brace double, monk
        public bool _equipped;          // Is the character activly using this item (occupies 'slot')
        public string _material;        // notable specific material the item is composed of
        public bool _masterwork;        // is the item masterwork
        public ushort _armorBonus;      // bonus this item gives to armor
        public ushort _maxDex;          // character maximum dextarity bonus when this item is 'equipped'
        public short _armorPenalty;     // armor check penalty when 'equipped'
        public short _arcSpellFail;     // arcain spell failure chance when 'equipped'
        public string _speedPenalty;    // 'none', 'light', or 'heavy combat movement speed penalty
        public string _dependancy;      // e.g. to use armor spikes the armor must be equipped
        public string _itemType;        // generic item, weapon, armor, wonderous

        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); } }
        public double Weight { get { return _weight; } set { _weight = value; RaisePropertyChanged("Weight"); } }
        public double Value { get { return _value; } set { _value = value; RaisePropertyChanged("Value"); } }
        public string Description { get { return _description; } set { _description = value; RaisePropertyChanged("Description"); } }
        public GearSlots Slot { get { return _slot; } set { _slot = value; RaisePropertyChanged("Slot"); } }
        public List<Spell> Spells { get { return _spells; } set { _spells = value; RaisePropertyChanged("Spells"); } }
        public uint Amount { get { return _amount; } set { _amount = value; RaisePropertyChanged("Amount"); } }
        public bool Unique { get { return _unique; } set { _unique = value; RaisePropertyChanged("Unique"); } }
        public ushort DmgMultiplier { get { return _dmgMultiplier; } set { _dmgMultiplier = value; RaisePropertyChanged("DmgMultiplier"); } }
        public ushort DmgAmount { get { return _dmgAmount; } set { _dmgAmount = value; RaisePropertyChanged("DmgAmount"); } }
        public ushort CrtMultiplier { get { return _crtMultiplier; } set { _crtMultiplier = value; RaisePropertyChanged("CrtMultiplier"); } }
        public uint Range { get { return _range; } set { _range = value; RaisePropertyChanged("Range"); } }
        public char DmgType { get { return _dmgType; } set { _dmgType = value; RaisePropertyChanged("DmgType"); } }
        public string WepFeatures { get { return _wepFeatures; } set { _wepFeatures = value; RaisePropertyChanged("WepFeatures"); } }
        public bool Equipped { get { return _equipped; } set { _equipped = value; RaisePropertyChanged("Equipped"); } }
        public string Material { get { return _material; } set { _material = value; RaisePropertyChanged("Material"); } }
        public bool Masterwork { get { return _masterwork; } set { _masterwork = value; RaisePropertyChanged("Masterwork"); } }
        public ushort ArmorBonus { get { return _armorBonus; } set { _armorBonus = value; RaisePropertyChanged("ArmorBonus"); } }
        public ushort MaxDex { get { return _maxDex; } set { _maxDex = value; RaisePropertyChanged("MaxDex"); } }
        public short ArmorPenalty { get { return _armorPenalty; } set { _armorPenalty = value; RaisePropertyChanged("ArmorPenalty"); } }
        public short ArcSpellFail { get { return _arcSpellFail; } set { _arcSpellFail = value; RaisePropertyChanged("ArcSpellFail"); } }
        public string SpeedPenalty { get { return _speedPenalty; } set { _speedPenalty = value; RaisePropertyChanged("SpeedPenalty"); } }
        public string Dependancy { get { return _dependancy; } set { _dependancy = value; RaisePropertyChanged("Dependancy"); } }
        public string ItemType { get { return _itemType; } set { _itemType = value; RaisePropertyChanged("ItemType"); } }

    }
}
