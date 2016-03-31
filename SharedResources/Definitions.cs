using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources
{
    public static class Definitions
    {
        public static readonly Dictionary<string, string> Spells = new Dictionary<string, string>
        {
            {"",""},
        };

        public static readonly Dictionary<string, string> Feats = new Dictionary<string, string>
        {
            {"Dodge","The description for dodge."},
            {"Mobility","The description for mobility."},
            {"Power Attack","The description for power attack."},
            {"Weapon Focus",string.Format("The \nFormatted \ndescription \nfor weapon focus.")},
            {"Spring Attack","The description for spring attack."},
        };

        public static readonly Dictionary<string, string> Skills = new Dictionary<string, string>
        {
            {"",""},
        };
    }
}
