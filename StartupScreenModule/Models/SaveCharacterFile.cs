using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ActiveCharacter;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Specialized;
using ModuleTools;


namespace StartupScreenModule.Models
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
            //string output = "{";
            string output = string.Empty;

            output += jsonSkill();
            output += "\n";
            output += jsonCharacterInfo(); 
            output += "\n";
            output += jsonWealth();
            output += "\n";
            output += jsonCombat();

            //output += "}";

            StreamWriter writer = new StreamWriter(filename + ".pf");

            writer.Write(output);

            writer.Close();

            return true;
        }        

        public string jsonSkill()
        {
            string output = string.Empty;
            //OrderedDictionary dict = new OrderedDictionary();

            //foreach (var elem in Character.Skills)
            //{
            //    dict.Add(elem.Key, elem.Value);
            //}

            //dict.Add("acrobatics", Character.acrobatics);
            //dict.Add("appraise", Character.appraise);
            //dict.Add("bluff", Character.bluff);
            //dict.Add("climb", Character.climb);
            //dict.Add("craft", Character.craft);
            //dict.Add("diplomacy", Character.diplomacy);
            //dict.Add("disableDevice", Character.disableDevice);
            //dict.Add("disguise", Character.disguise);
            //dict.Add("escapeArtist", Character.escapeArtist);
            //dict.Add("fly", Character.fly);
            //dict.Add("handleAnimal", Character.handleAnimal);
            //dict.Add("heal", Character.heal);
            //dict.Add("intimidate", Character.intimidate);
            //dict.Add("knowledgeArcana", Character.knowledgeArcana);
            //dict.Add("knowledgeDungeoneering", Character.knowledgeDungeoneering);
            //dict.Add("knowledgeEngineering", Character.knowledgeEngineering);
            //dict.Add("knowledgeGeography", Character.knowledgeGeography);
            //dict.Add("knowledgeHistory", Character.knowledgeHistory);
            //dict.Add("knowledgeLocal", Character.knowledgeLocal);
            //dict.Add("knowledgeNature", Character.knowledgeNature);
            //dict.Add("knowledgeNobility", Character.knowledgeNobility);
            //dict.Add("knowledgePlanes", Character.knowledgePlanes);
            //dict.Add("knowledgeReligion", Character.knowledgeReligion);
            //dict.Add("linguistics", Character.linguistics);
            //dict.Add("perception", Character.perception);
            //dict.Add("perform", Character.perform);
            //dict.Add("profession", Character.profession);
            //dict.Add("ride", Character.ride);
            //dict.Add("senseMotive", Character.senseMotive);
            //dict.Add("sleightOfHand", Character.sleightOfHand);
            //dict.Add("spellcraft", Character.spellcraft);
            //dict.Add("stealth", Character.stealth);
            //dict.Add("survival", Character.survival);
            //dict.Add("swim", Character.swim);
            //dict.Add("useMagicDevice", Character.useMagicDevice);

            //output += "\"skills\":";
            //output += JsonConvert.SerializeObject(dict);
            output += JsonConvert.SerializeObject(Character.Skills, Formatting.None);

            return output;
        }

        public string jsonWealth()
        {   
            string output = string.Empty;
            //OrderedDictionary dict = new OrderedDictionary();
            
            //dict.Add("gold", Character.gold);
            //dict.Add("gear", Character.gear);
            //dict.Add("equipment", Character.equipment);
            //dict.Add("weapons", Character.weapons);
            //dict.Add("armor", Character.armor);
            
            output += JsonConvert.SerializeObject(Character.Gear, Formatting.None);
            //output += JsonConvert.SerializeObject(dict);

            return output;
        }

        public string jsonCombat()
        {
            string output = string.Empty;
            OrderedDictionary dict = new OrderedDictionary();

            output += JsonConvert.SerializeObject(Character.Combat, Formatting.None);

            //dict.Add("hitPoints", Character.hitPoints);
            //dict.Add("initiative", Character.initiative);
            //dict.Add("armorClass", Character.armorClass);
            //dict.Add("fortitudeSave", Character.fortitudeSave);
            //dict.Add("reflexSave", Character.reflexSave);
            //dict.Add("willSave", Character.willSave);
            //dict.Add("baseAttackBonus", Character.baseAttackBonus);
            //dict.Add("combatManeuverBonus", Character.combatManeuverBonus);
            //dict.Add("combatManeuverDefence", Character.combatManeuverDefence);
            //dict.Add("statusEffect", Character.statusEffect);
            //dict.Add("encumbrance", Character.encumbrance);
            //dict.Add("movement_combat", Character.movement_combat);
            //output += "\"combat\":";
            //output += JsonConvert.SerializeObject(dict);

            return output;
        }

        public string jsonCharacterInfo()
        {
            string output = string.Empty;
            //OrderedDictionary dict = new OrderedDictionary();

            //dict.Add("characterName", Character.characterName);
            //dict.Add("playerName", Character.playerName);
            //dict.Add("race", Character.race);
            //dict.Add("jobclass", Character.jobclass);
            //dict.Add("size", Character.size);
            //dict.Add("alignment", Character.alignment);
            //dict.Add("age", Character.age);
            //dict.Add("deity", Character.deity);
            //dict.Add("gender", Character.gender);
            //dict.Add("height", Character.height);
            //dict.Add("weight", Character.weight);
            //dict.Add("eyes", Character.eyes);
            //dict.Add("hair", Character.hair);
            //dict.Add("homeland", Character.homeland);
            //dict.Add("strength", Character.strength);
            //dict.Add("dexterity", Character.dexterity);
            //dict.Add("constitution", Character.constitution);
            //dict.Add("intelligence", Character.intelligence);
            //dict.Add("wisdom", Character.wisdom);
            //dict.Add("charisma", Character.charisma);
            //dict.Add("languages", Character.languages);
            //dict.Add("experiencePoints", Character.experiencePoints);
            //output += "\"character\":";
            output += JsonConvert.SerializeObject(Character.Information, Formatting.None);

            //output += JsonConvert.SerializeObject(dict);

            return output;
        }
    }
}
