using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataObjects.CharacterDataElements
{
    public class ArmorClass
    {
        private int total;
        private const int baseValue = 10;
        private int armorBonus;
        private int sheildBonus;
        private int dextarityModifier;
        private int sizeModifier;
        private int naturalArmor;
        private int deflectionModifier;
        private int miscModifier;
        private int touch;
        private int flatFooted;
        
        public int Total { get { return total; } set { total = value; } }
        private int ArmorBonus;
        private int SheildBonus;
        private int DextarityModifier;
        private int SizeModifier;
        private int NaturalArmor;
        private int DeflectionModifier;
        private int MiscModifier;
        private int Touch;
        private int FlatFooted;

    }
}
