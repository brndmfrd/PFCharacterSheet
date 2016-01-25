using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ActiveCharacter;


namespace Archivist
{
    public static class SaveCharacterFile
    {
        /// <summary>
        /// Called to write the Active Character data to file.
        /// </summary>
        /// <param name="filename">Filename that will be appended with ".pf" suffix.</param>
        /// <returns></returns>
        public static void SaveCharacter(string filename = "FACECAFE")
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
        }



        private static string jsonSkill()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.Skills, Formatting.None);
            return output;
        }

        private static string jsonWealth()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.Gear, Formatting.None);
            return output;
        }

        private static string jsonCharacterInfo()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.Information, Formatting.None);
            return output;
        }





    }
}
