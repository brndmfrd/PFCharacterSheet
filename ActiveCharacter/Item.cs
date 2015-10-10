using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveCharacter
{
    public class Item
    {
        public string name;            // the name of the type of item e.g. short sword, crowbar, scroll of magic missle
        public double weight;          // weight per single instance of the item in kg
        public double value;           // market value in gold; lesser denominations as decimal values
        public string description;     // short description of refrence info about the item
        public string slot;            // item slot used when the item is active/'equipped' (head, left hand, feet). 
        public List<Spell> spells      // spell, magical ability, aura, CL, number of charges 
            = new List<Spell>();
        public uint amount;            // number of copies that are 'stacked' with this item
        public bool unique;            // signifies the item as unique/modified. Do not stack this with 'common' items.
        public ushort dmgMultiplier;   // The 1 in the 1d8 or the 3 in the 3d6
        public ushort dmgAmount;       // The 8 in the 1d8 or the 6 in the 3d6
        public ushort crtMultiplier;   // Critical hit multiplier x1, x2, x3, x4
        public uint range;             // Effective range the item can be thrown
        public char dmgType;           // P := peircing, B := Bludgeoning, S := Slashing
        public string wepFeatures;     // Reach, nonleathal, trip, disarm, brace double, monk
        public bool equipped;          // Is the character activly using this item (occupies 'slot')
        public string material;        // notable specific material the item is composed of
        public bool masterwork;        // is the item masterwork
        public ushort armorBonus;      // bonus this item gives to armor
        public ushort maxDex;          // character maximum dextarity bonus when this item is 'equipped'
        public short armorPenalty;     // armor check penalty when 'equipped'
        public short arcSpellFail;     // arcain spell failure chance when 'equipped'
        public string speedPenalty;    // 'none', 'light', or 'heavy combat movement speed penalty
        public string dependancy;      // e.g. to use armor spikes the armor must be equipped
    }
}
