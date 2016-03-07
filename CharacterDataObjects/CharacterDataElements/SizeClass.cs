using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;

namespace CharacterDataObjects.CharacterDataElements
{
    public class SizeClass
    {
        #region Private Fields
        private Enums.Size sizeCatagory = Enums.Size.Medium;
        private int sizeModifier = 0;
        private int[] sizeModifierValues = { -8, -4, -2, -1, 0, 1, 2, 4, 8 };
        #endregion Private Fields

        #region Public Accessors
        public string Size {
            get { return sizeCatagory.ToString(); }
            set { sizeCatagory = SizeStringToEnum(value); }
        }

        public int SizeModifier
        {
            get { return sizeModifierValues[(int)sizeCatagory]; }
        }
        #endregion Public Accessors

        #region Private Methods
        private Enums.Size SizeStringToEnum(string sizeclass)
        {
            switch (sizeclass)
            {
                case (Constants.Colossal):
                    return Enums.Size.Colossal;
                case (Constants.Gargantuan):
                    return Enums.Size.Gargantuan;
                case (Constants.Huge):
                    return Enums.Size.Huge;
                case (Constants.Large):
                    return Enums.Size.Large;
                case (Constants.Medium):
                    return Enums.Size.Medium;
                case (Constants.Small):
                    return Enums.Size.Small;
                case (Constants.Tiny):
                    return Enums.Size.Tiny;
                case (Constants.Diminutive):
                    return Enums.Size.Diminutive;
                case (Constants.Fine):
                    return Enums.Size.Fine;
                default:
                    return Enums.Size.ERROR;
            }

        }
        #endregion Private Methods



    }
}
