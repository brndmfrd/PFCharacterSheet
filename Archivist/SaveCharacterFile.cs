using Newtonsoft.Json;
using System.IO;
using CharacterDataObjects;

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
            output += JsonConvert.SerializeObject(MyCharacter.Skills, Formatting.None);
            return output;
        }

        private static string jsonWealth()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(MyCharacter.Gear, Formatting.None);
            return output;
        }

        private static string jsonCharacterInfo()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(MyCharacter.BasicCharacterInfo, Formatting.None);
            return output;
        }





    }
}
