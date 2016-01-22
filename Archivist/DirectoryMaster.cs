using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Archivist
{
    //RaisePropertyChangedEvent
    public static class DirectoryMaster
    {
        private const string filenamePattern = @"[^\\]+\.pf$";
        private static Regex rgx;
        private static ObservableCollection<string> directoryFileList = new ObservableCollection<string>();


        public static string DefaultDirectory = "";        
        public static ObservableCollection<string> DirectoryFileList { get { return directoryFileList; } }

        /// <summary>
        /// Look into the default dir and return all .pf files.
        /// </summary>
        /// <returns></returns>
        public static void GetFilesFromDefaultDir()
        {
            var cdir = Directory.GetCurrentDirectory();             // Target local directory

            var pfFiles = Directory.GetFiles(cdir, "*.pf");         // Target .pf files

            directoryFileList.Clear();

            // There are no *.pf files!
            if (pfFiles.Length == 0)
            {
                directoryFileList.Insert(0, "No files could be found");
            }

            rgx = new Regex(filenamePattern, RegexOptions.RightToLeft);

            for (int i = 0; i < pfFiles.Length; i++)
            {
                directoryFileList.Insert(i, rgx.Match(pfFiles[i]).Value);
            }
        }

    }
}
