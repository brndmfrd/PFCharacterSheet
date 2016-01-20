using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using ActiveCharacter;
using System.Collections.ObjectModel;

namespace OptionsModule.Models
{
    public static class LoadCharacter
    {
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
    }
}
