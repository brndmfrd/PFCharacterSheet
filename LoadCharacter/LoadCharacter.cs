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
        string cdir;        // full path of our cwd
        string file;        // our character file to load
        string[] pfFiles;   // list of files in cwd

        /// <summary>
        /// Constructor. Sets the character file as the first pathfinder file in the CWD by default. 
        /// </summary>
        public LoadCharacter()
        {
            cdir = Directory.GetCurrentDirectory();
            file = GetFirstPfFile();
        }

        /// <summary>
        /// Return the fist pathfinder file in the cwd
        /// </summary>
        /// <returns></returns>
        private string GetFirstPfFile()
        {
            // We want the files that end with .pf
            pfFiles = Directory.GetFiles(cdir, "*.pf");

            return pfFiles.FirstOrDefault();
        }

        

        
    }
}
