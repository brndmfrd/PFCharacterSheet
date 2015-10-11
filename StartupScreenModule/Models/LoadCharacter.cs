using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Specialized;
using ActiveCharacter;
using System.Collections.ObjectModel;

namespace StartupScreenModule.Models
{
    public static class LoadCharacter
    {
        // current working directory
        private static string cdir;                        // full path of our cwd
        private static string characterFileAndPath;        // our character file to load
        private static string[] pfFiles;                   // list of files in cwd


        //todo: if the path fails to be set we must indicate it to the user.  Add some sort of message logging the user can ref. from where this value tries to get set (codebehind).
        /// <summary>
        /// Setting this value affirms loading of a new character file.
        /// </summary>
        public static string CharacterfileAndPath
        {
            get { return characterFileAndPath; }
            set
            {
                if (ValidatePath(value))
                {
                    characterFileAndPath = value;
                    BeginLoadCharacterFile(value);
                }
            }
        }
        
        
        public static string[] PfFiles
        {
            get { return pfFiles; }
            set { pfFiles = value; }
        }

        /// <summary>
        /// Begin loading the character file from disk.
        /// A valid file is of this format: 
        /// {"Acrobatics":0,"Appraise":0...}\n
        /// "wealth":{"gold":"noval","gear":"noval"...}\n
        /// "character":{"characterName":"noval",...}\n
        /// "combat":{"hitPoints":"noval",...}\n
        /// todo: ensure this is accurate, since the file format WILL change.
        /// </summary>
        /// <param name="value">The verified character full file path.</param>
        private static void BeginLoadCharacterFile(string value)
        {
            // Bryan's snippit for debugging - ignorable
            //SaveCharacterFile savechar = new SaveCharacterFile();
            //savechar.SaveCharacter();

            // Try to get the file - It may be locked (in use)
            try
            {
                using (StreamReader sr = File.OpenText(value))
                {
                    while (!sr.EndOfStream)
                    {
                        // First line expected to be Skills
                        var line = sr.ReadLine();

                        try
                        {
                            Character.Skills = JsonConvert.DeserializeObject<ObservableCollection<Skill>>(line);
                        }
                        catch (Exception ex)
                        {
                            // log that the file is not valid.  
                            // notify user that the character data may be incomplete.
                            // perhaps we can add some fault-tolerance, backup, and/or recovery later.
                        }

                        // Second line expected to be Character Information
                        line = sr.ReadLine();

                        try
                        {
                            Character.Information = JsonConvert.DeserializeObject<ObservableCollection<BasicInformation>>(line);
                        }
                        catch (Exception ex)
                        {
                            // log that the file is not valid.  
                            // notify user that the character data may be incomplete.
                            // perhaps we can add some fault-tolerance, backup, and/or recovery later.
                        }

                        // Third line expected to be Gear
                        line = sr.ReadLine();

                        try
                        {
                            Character.Gear = JsonConvert.DeserializeObject<ObservableCollection<Item>>(line);
                        }
                        catch (Exception ex)
                        {
                            // log that the file is not valid.  
                            // notify user that the character data may be incomplete.
                            // perhaps we can add some fault-tolerance, backup, and/or recovery later.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // log an error has occured in loading of charcter file
                // notify user that the file may be locked and to close any currently open instance of the file
            }

            
        }


        /// <summary>
        /// Validate a useable pathfinder character file to use
        /// </summary>
        /// <param name="value">Full path of a character file</param>
        /// <returns>bool: validity</returns>
        private static bool ValidatePath(string value)
        {
            // does the file exist
            if (!File.Exists(value))
            {
                return false;
            }

            var lenFile = value.Length;

            // If the file name length is stupid, reject it
            if (lenFile <= 3 || lenFile >= 255)
            {
                return false;
            }

            // Check Prefix
            if (value.Substring(lenFile - 3, 3) != ".pf")
            {
                return false;
            }

            return true;            
        }

        
        /// <summary>
        /// Look into the default dir and return all .pf files paths.
        /// </summary>
        /// <returns></returns>
        public static string[] GetFilesFromDefaultDir()
        {
            cdir = Directory.GetCurrentDirectory();             // Target local directory

            pfFiles = Directory.GetFiles(cdir, "*.pf");         // Target .pf files

            if (pfFiles[0] == null)
            {
                pfFiles[0] = "No files could be found";
            }

            return pfFiles;
        }


        /// <summary>
        /// Return the fist pathfinder file in the cwd
        /// </summary>
        /// <returns>The full path of the first file with with a .pf extension, or a null string.</returns>
        public static string GetFirstPfFile()
        {
            cdir = Directory.GetCurrentDirectory();             // Target local directory

            pfFiles = Directory.GetFiles(cdir, "*.pf");         // Target first .pf file

            characterFileAndPath = pfFiles.FirstOrDefault();    // Set the filepath or return a null string

            return characterFileAndPath;
        }
    }
}
