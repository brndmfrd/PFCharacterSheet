using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using ActiveCharacter;
using System.Collections.ObjectModel;
using log4net;

namespace Archivist
{
    public static class LoadCharacterFile
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoadCharacterFile));

        /// <summary>
        /// Reads serialized json character information from file and stores information in the Active Character.
        /// </summary>
        /// <param name="value">Pathfinder file name. File name sanitation is assumed to be checked at this point.</param>
        public static void BeginLoadCharacterFile(string value)
        {
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
                            // Out with the old...
                            Character.Skills.Clear();

                            // create a temp container
                            var x = new ObservableCollection<Skill>();

                            // fill our temp container
                            x = JsonConvert.DeserializeObject<ObservableCollection<Skill>>(line);

                            // worth noting that ObservableCollections will 'auto update' this way and not if you 
                            // directly assign to it; i.e.  Character.Skills = JsonConvert.DeserializeObject<ObservableCollection<Skill>>(line);
                            // we want to change our collection container, not replace it.
                            foreach(var elem in x){
                                Character.Skills.Add(elem);
                            }
                        }
                        catch (Exception ex)
                        {
                            log.ErrorFormat("Error when parsing line for SKILLS. \n{0}\n{1}", line, ex);
                            // notify user that the character data may be incomplete.
                        }

                        // Second line expected to be Character Information
                        line = sr.ReadLine();

                        try
                        {
                            Character.Information.Clear();
                            var x = new ObservableCollection<BasicInformation>();
                            x = JsonConvert.DeserializeObject<ObservableCollection<BasicInformation>>(line);
                            foreach (var elem in x)
                            {
                                Character.Information.Add(elem);
                            }
                        }
                        catch (Exception ex)
                        {
                            log.ErrorFormat("Error when parsing line for BASIC INFORMATION. \n{0}\n{1}", line, ex);
                            // notify user that the character data may be incomplete.
                        }

                        // Third line expected to be Gear
                        line = sr.ReadLine();

                        try
                        {
                            Character.Gear.Clear();
                            var x = new ObservableCollection<Item>();
                            x = JsonConvert.DeserializeObject<ObservableCollection<Item>>(line);
                            foreach (var elem in x)
                            {
                                Character.Gear.Add(elem);
                            }
                        }
                        catch (Exception ex)
                        {
                            log.ErrorFormat("Error when parsing line for GEAR. \n{0}\n{1}", line, ex);
                            // notify user that the character data may be incomplete.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Failure to read from selected character file.\n{0}", ex);
                // log an error has occured in loading of charcter file
                // notify user that the file may be locked and to close any currently open instance of the file
            }
        }
    }
}
