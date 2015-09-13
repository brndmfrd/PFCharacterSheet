using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoadCharacter
{
    public class LoadCharacter
    {
        // current working directory
        private string cdir;                        // full path of our cwd
        private string characterFileAndPath;        // our character file to load
        private string[] pfFiles;                   // list of files in cwd

        public string CharacterfileAndPath
        {
            get { return characterFileAndPath; }
            set { characterFileAndPath = value; }
        }

        public string[] PfFiles
        {
            get { return pfFiles; }
            set { pfFiles = value; }
        }


        /// <summary>
        /// Constructor. Sets the character file as the first pathfinder file in the CWD by default. 
        /// </summary>
        public LoadCharacter()
        {
            cdir = Directory.GetCurrentDirectory();
            characterFileAndPath = GetFirstPfFile();
        }


        

        /// <summary>
        /// Return the fist pathfinder file in the cwd
        /// </summary>
        /// <returns>The full path of the first file with with a .pf extension, or a null string.</returns>
        private string GetFirstPfFile()
        {
            // We want the files that end with .pf
            pfFiles = Directory.GetFiles(cdir, "*.pf");

            return pfFiles.FirstOrDefault();
        }

        

        
    }
}
