using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivist
{
    public static class CurrentActiveConfig
    {
        public static string filename = "default.py";
        public static string saveDirectory = Directory.GetCurrentDirectory();
        public static int? autoSaveFrequency = null;
        public static DateTime? lastSave = DateTime.Now;
    }
}
