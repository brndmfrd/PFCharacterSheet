using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using ModuleTools;

namespace CharacterModule.Model
{
    // todo: add more languages and classes
    public class CharacterModel
    {
        public static string CharacterName { get { return Character.Information[Constants.characterName]; } set { Character.Information[Constants.characterName] = value; } }
        public static string PlayerName { get { return Character.Information[Constants.playerName]; } set { Character.Information[Constants.playerName] = value; } }
        public static string Race { get { return Character.Information[Constants.race]; } set { Character.Information[Constants.race] = value; } }
        public static string Size { get { return Character.Information[Constants.size]; } set { Character.Information[Constants.size] = value; } }
        public static string Alignment { get { return Character.Information[Constants.alignment]; } set { Character.Information[Constants.alignment] = value; } }
        public static string Age { get { return Character.Information[Constants.age]; } set { Character.Information[Constants.age] = value; } }
        public static string Deity { get { return Character.Information[Constants.deity]; } set { Character.Information[Constants.deity] = value; } }
        public static string Gender { get { return Character.Information[Constants.gender]; } set { Character.Information[Constants.gender] = value; } }
        public static string Height { get { return Character.Information[Constants.height]; } set { Character.Information[Constants.height] = value; } }
        public static string Weight { get { return Character.Information[Constants.weight]; } set { Character.Information[Constants.weight] = value; } }
        public static string Eyes { get { return Character.Information[Constants.eyes]; } set { Character.Information[Constants.eyes] = value; } }
        public static string Hair { get { return Character.Information[Constants.hair]; } set { Character.Information[Constants.hair] = value; } }
        public static string Homeland { get { return Character.Information[Constants.homeland]; } set { Character.Information[Constants.homeland] = value; } }
        public static string Strength { get { return Character.Information[Constants.strength]; } set { Character.Information[Constants.strength] = value; } }
        public static string Dexterity { get { return Character.Information[Constants.dexterity]; } set { Character.Information[Constants.dexterity] = value; } }
        public static string Constitution { get { return Character.Information[Constants.constitution]; } set { Character.Information[Constants.constitution] = value; } }
        public static string Intelligence { get { return Character.Information[Constants.intelligence]; } set { Character.Information[Constants.intelligence] = value; } }
        public static string Wisdom { get { return Character.Information[Constants.wisdom]; } set { Character.Information[Constants.wisdom] = value; } }
        public static string Charisma { get { return Character.Information[Constants.charisma]; } set { Character.Information[Constants.charisma] = value; } }
        public static string Common { get { return Character.Information[Constants.common]; } set { Character.Information[Constants.common] = value; } }
        public static string Dwarven { get { return Character.Information[Constants.dwarven]; } set { Character.Information[Constants.dwarven] = value; } }
        public static string Draconic { get { return Character.Information[Constants.draconic]; } set { Character.Information[Constants.draconic] = value; } }
        public static string ExperiencePoints { get { return Character.Information[Constants.experiencePoints]; } set { Character.Information[Constants.experiencePoints] = value; } }
        public static string Barbarian { get { return Character.Information[Constants.barbarian]; } set { Character.Information[Constants.barbarian] = value; } }
        public static string Bard { get { return Character.Information[Constants.bard]; } set { Character.Information[Constants.bard] = value; } }
        public static string Cleric { get { return Character.Information[Constants.cleric]; } set { Character.Information[Constants.cleric] = value; } }
        public static string Druid { get { return Character.Information[Constants.druid]; } set { Character.Information[Constants.druid] = value; } }
        public static string Fighter { get { return Character.Information[Constants.fighter]; } set { Character.Information[Constants.fighter] = value; } }
        public static string Ranger { get { return Character.Information[Constants.ranger]; } set { Character.Information[Constants.ranger] = value; } }
        public static string Sorcerer { get { return Character.Information[Constants.sorcerer]; } set { Character.Information[Constants.sorcerer] = value; } }
        public static string Wizard { get { return Character.Information[Constants.wizard]; } set { Character.Information[Constants.wizard] = value; } }
    }
}
