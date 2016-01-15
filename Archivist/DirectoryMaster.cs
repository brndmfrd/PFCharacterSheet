using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivist
{
    public static class DirectoryMaster
    {
        public static string DefaultDirectory = "";
        public static ObservableCollection<string> DirectoryFileList { get { return GetFilesFromDefaultDir(); } set { } }

        /// <summary>
        /// Look into the default dir and return all .pf files paths.
        /// </summary>
        /// <returns></returns>
        private static ObservableCollection<string> GetFilesFromDefaultDir()
        {
            var cdir = Directory.GetCurrentDirectory();             // Target local directory

            var pfFiles = Directory.GetFiles(cdir, "*.pf");         // Target .pf files
            // todo: error handling needed if there are no *.pf files!
            if (pfFiles[0] == null)
            {
                pfFiles[0] = "No files could be found";
            }

            return new ObservableCollection<string>(pfFiles);
        }

    }
}
