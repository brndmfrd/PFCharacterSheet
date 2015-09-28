using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCharacter;
using ModuleTools;

namespace SpellsFeatsSkillsModule.Models
{
    public class SkillModel
    {
        public static int Acrobatics { get { return Character.Skills[Constants.acrobatics]; } set { Character.Skills[Constants.acrobatics] = value; } }
        public static int Appraise { get { return Character.Skills[Constants.appraise]; } set { Character.Skills[Constants.appraise] = value; } }
        public static int Bluff { get { return Character.Skills[Constants.bluff]; } set { Character.Skills[Constants.bluff] = value; } }
        public static int Climb { get { return Character.Skills[Constants.climb]; } set { Character.Skills[Constants.climb] = value; } }
        public static int Craft { get { return Character.Skills[Constants.craft]; } set { Character.Skills[Constants.craft] = value; } }
        public static int Diplomacy { get { return Character.Skills[Constants.diplomacy]; } set { Character.Skills[Constants.diplomacy] = value; } }
        public static int DisableDevice { get { return Character.Skills[Constants.disableDevice]; } set { Character.Skills[Constants.disableDevice] = value; } }
        public static int Disguise { get { return Character.Skills[Constants.disguise]; } set { Character.Skills[Constants.disguise] = value; } }
        public static int EscapeArtist { get { return Character.Skills[Constants.escapeArtist]; } set { Character.Skills[Constants.escapeArtist] = value; } }
        public static int Fly { get { return Character.Skills[Constants.fly]; } set { Character.Skills[Constants.fly] = value; } }
        public static int HandleAnimal { get { return Character.Skills[Constants.handleAnimal]; } set { Character.Skills[Constants.handleAnimal] = value; } }
        public static int Heal { get { return Character.Skills[Constants.heal]; } set { Character.Skills[Constants.heal] = value; } }
        public static int Intimidate { get { return Character.Skills[Constants.intimidate]; } set { Character.Skills[Constants.intimidate] = value; } }
        public static int KnowledgeArcana { get { return Character.Skills[Constants.knowledgeArcana]; } set { Character.Skills[Constants.knowledgeArcana] = value; } }
        public static int KnowledgeDungeoneering { get { return Character.Skills[Constants.knowledgeDungeoneering]; } set { Character.Skills[Constants.knowledgeDungeoneering] = value; } }
        public static int KnowledgeEngineering { get { return Character.Skills[Constants.knowledgeEngineering]; } set { Character.Skills[Constants.knowledgeEngineering] = value; } }
        public static int KnowledgeGeography { get { return Character.Skills[Constants.knowledgeGeography]; } set { Character.Skills[Constants.knowledgeGeography] = value; } }
        public static int KnowledgeHistory { get { return Character.Skills[Constants.knowledgeHistory]; } set { Character.Skills[Constants.knowledgeHistory] = value; } }
        public static int KnowledgeLocal { get { return Character.Skills[Constants.knowledgeLocal]; } set { Character.Skills[Constants.knowledgeLocal] = value; } }
        public static int KnowledgeNature { get { return Character.Skills[Constants.knowledgeNature]; } set { Character.Skills[Constants.knowledgeNature] = value; } }
        public static int KnowledgeNobility { get { return Character.Skills[Constants.knowledgeNobility]; } set { Character.Skills[Constants.knowledgeNobility] = value; } }
        public static int KnowledgePlanes { get { return Character.Skills[Constants.knowledgePlanes]; } set { Character.Skills[Constants.knowledgePlanes] = value; } }
        public static int KnowledgeReligion { get { return Character.Skills[Constants.knowledgeReligion]; } set { Character.Skills[Constants.knowledgeReligion] = value; } }
        public static int Linguistics { get { return Character.Skills[Constants.linguistics]; } set { Character.Skills[Constants.linguistics] = value; } }
        public static int Perception { get { return Character.Skills[Constants.perception]; } set { Character.Skills[Constants.perception] = value; } }
        public static int Perform { get { return Character.Skills[Constants.perform]; } set { Character.Skills[Constants.perform] = value; } }
        public static int Profession { get { return Character.Skills[Constants.profession]; } set { Character.Skills[Constants.profession] = value; } }
        public static int Ride { get { return Character.Skills[Constants.ride]; } set { Character.Skills[Constants.ride] = value; } }
        public static int SenseMotive { get { return Character.Skills[Constants.senseMotive]; } set { Character.Skills[Constants.senseMotive] = value; } }
        public static int SleightOfHand { get { return Character.Skills[Constants.sleightOfHand]; } set { Character.Skills[Constants.sleightOfHand] = value; } }
        public static int Spellcraft { get { return Character.Skills[Constants.spellcraft]; } set { Character.Skills[Constants.spellcraft] = value; } }
        public static int Stealth { get { return Character.Skills[Constants.stealth]; } set { Character.Skills[Constants.stealth] = value; } }
        public static int Survival { get { return Character.Skills[Constants.survival]; } set { Character.Skills[Constants.survival] = value; } }
        public static int Swim { get { return Character.Skills[Constants.swim]; } set { Character.Skills[Constants.swim] = value; } }
        public static int UseMagicDevice { get { return Character.Skills[Constants.useMagicDevice]; } set { Character.Skills[Constants.useMagicDevice] = value; } }
    }
}
