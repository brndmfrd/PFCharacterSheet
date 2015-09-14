using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ActiveCharacter;
using Newtonsoft.Json;


namespace StartupScreenModule.Models
{
    public class SaveCharacterFile
    {
        /// <summary>
        /// Default constructor created for unit testing
        /// </summary>
        public SaveCharacterFile(){}

        public SaveCharacterFile(string filename)
        {
            string output;

            output = jsonSkill();
        }

        public string jsonSkill()
        {
            string output = string.Empty;
            output += JsonConvert.SerializeObject(Character.acrobatics);
            output += JsonConvert.SerializeObject(Character.appraise);
            output += JsonConvert.SerializeObject(Character.bluff);
            output += JsonConvert.SerializeObject(Character.climb);
            output += JsonConvert.SerializeObject(Character.craft);
            output += JsonConvert.SerializeObject(Character.diplomacy);
            output += JsonConvert.SerializeObject(Character.disableDevice);
            output += JsonConvert.SerializeObject(Character.disguise);
            output += JsonConvert.SerializeObject(Character.escapeArtist);
            output += JsonConvert.SerializeObject(Character.fly);
            output += JsonConvert.SerializeObject(Character.handleAnimal);
            output += JsonConvert.SerializeObject(Character.heal);
            output += JsonConvert.SerializeObject(Character.intimidate);
            output += JsonConvert.SerializeObject(Character.knowledgeArcana);
            output += JsonConvert.SerializeObject(Character.knowledgeDungeoneering);
            output += JsonConvert.SerializeObject(Character.knowledgeEngineering);
            output += JsonConvert.SerializeObject(Character.knowledgeGeography);
            output += JsonConvert.SerializeObject(Character.knowledgeHistory);
            output += JsonConvert.SerializeObject(Character.knowledgeLocal);
            output += JsonConvert.SerializeObject(Character.knowledgeNature);
            output += JsonConvert.SerializeObject(Character.knowledgeNobility);
            output += JsonConvert.SerializeObject(Character.knowledgePlanes);
            output += JsonConvert.SerializeObject(Character.knowledgeReligion);
            output += JsonConvert.SerializeObject(Character.linguistics);
            output += JsonConvert.SerializeObject(Character.perception);
            output += JsonConvert.SerializeObject(Character.perform);
            output += JsonConvert.SerializeObject(Character.profession);
            output += JsonConvert.SerializeObject(Character.ride);
            output += JsonConvert.SerializeObject(Character.senseMotive);
            output += JsonConvert.SerializeObject(Character.sleightOfHand);
            output += JsonConvert.SerializeObject(Character.spellcraft);
            output += JsonConvert.SerializeObject(Character.stealth);
            output += JsonConvert.SerializeObject(Character.survival);
            output += JsonConvert.SerializeObject(Character.swim);
            output += JsonConvert.SerializeObject(Character.useMagicDevice);

            return output;
        }

    }
}
