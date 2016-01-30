using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivist
{
    public static class CurrentActiveConfig
    {
        //public static string filename = string.Empty;
        //public static string saveDirectory = string.Empty;
        //public static int? autoSaveFrequency = null;
        //public static DateTime? lastSave = null;

        public static string filename = "slappyMcGoo.pf";
        public static string saveDirectory = "C:/Someplace";
        public static int? autoSaveFrequency = null;
        public static DateTime? lastSave = DateTime.Now;
    }
}
