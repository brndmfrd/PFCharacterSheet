using System.IO;
using ActiveCharacter;
using Newtonsoft.Json;


namespace OptionsModule.Models
{
    public class SaveCharacterFile
    {
        /// <summary>
        /// Default constructor created for unit testing
        /// </summary>
        public SaveCharacterFile(){}

        /// <summary>
        /// this is what will be called when we want to save a character
        /// </summary>
        /// <param name="filename">This is the desired filename that we would like to save it as default for testing but not writing to a file</param>
        /// <returns></returns>
        public bool SaveCharacter(string filename = "FACECAFE")
        {
            string output = string.Empty;

            output += jsonSkill();
            output += "\n";
            output += jsonCharacterInfo(); 
            output += "\n";
            output += jsonWealth();
            output += "\n";
            //output += jsonCombat();
            
            StreamWriter writer = new StreamWriter(filename + ".pf");

            writer.Write(output);

            writer.Close();

            return true;
        }        

        public string jsonSkill()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.Skills, Formatting.None);
            return output;
        }

        public string jsonWealth()
        {   
            string output = string.Empty;            
            output += JsonConvert.SerializeObject(Character.Gear, Formatting.None);
            return output;
        }

        public string jsonCharacterInfo()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.Information, Formatting.None);            
            return output;
        }
    }
}
