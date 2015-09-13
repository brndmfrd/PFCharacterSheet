using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StartupScreenModule.Models
{
    public static class LoadCharacter
    {
        // current working directory
        private static string cdir;                        // full path of our cwd
        private static string characterFileAndPath;        // our character file to load
        private static string[] pfFiles;                   // list of files in cwd

        public static string CharacterfileAndPath
        {
            get { return characterFileAndPath; }
            set { characterFileAndPath = value; }
        }

        public static string[] PfFiles
        {
            get { return pfFiles; }
            set { pfFiles = value; }
        }


        /// <summary>
        /// Return the fist pathfinder file in the cwd
        /// </summary>
        /// <returns>The full path of the first file with with a .pf extension, or a null string.</returns>
        private static string GetFirstPfFile()
        {
            cdir = Directory.GetCurrentDirectory();             // Target local directory

            pfFiles = Directory.GetFiles(cdir, "*.pf");         // Target first .pf file

            characterFileAndPath = pfFiles.FirstOrDefault();    // Set the filepath or return a null string

            return characterFileAndPath;
        }
    }
}
