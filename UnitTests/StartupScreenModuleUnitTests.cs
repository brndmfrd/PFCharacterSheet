using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartupScreenModule.Models;

namespace UnitTests
{
    [TestClass]
    public class StartupScreenModuleUnitTests
    {
        [TestMethod]
        public void jsonSkillTest()
        {
            SaveCharacterFile tester = new SaveCharacterFile();
            var output = tester.jsonSkill();
            Assert.AreEqual("\"skills\":{\"acrobatics\":0,\"appraise\":0,\"bluff\":0,\"climb\":0,\"craft\":0,\"diplomacy\":0,\"disableDevice\":0,\"disguise\":0,\"escapeArtist\":0,\"fly\":0,\"handleAnimal\":0,\"heal\":0,\"intimidate\":0,\"knowledgeArcana\":0,\"knowledgeDungeoneering\":0,\"knowledgeEngineering\":0,\"knowledgeGeography\":0,\"knowledgeHistory\":0,\"knowledgeLocal\":0,\"knowledgeNature\":0,\"knowledgeNobility\":0,\"knowledgePlanes\":0,\"knowledgeReligion\":0,\"linguistics\":0,\"perception\":0,\"perform\":0,\"profession\":0,\"ride\":0,\"senseMotive\":0,\"sleightOfHand\":0,\"spellcraft\":0,\"stealth\":0,\"survival\":0,\"swim\":0,\"useMagicDevice\":0}", output);
        }

        [TestMethod]
        public void jsonWealthTest()
        {
            SaveCharacterFile tester = new SaveCharacterFile();
            var output = tester.jsonWealth();
            Assert.AreEqual("\"wealth\":{\"gold\":\"noval\",\"gear\":\"noval\",\"equipment\":\"noval\",\"weapons\":\"noval\",\"armor\":\"noval\"}", output);
        }

        [TestMethod]
        public void testSaveCharacter()
        {
            SaveCharacterFile tester = new SaveCharacterFile();
            var output = tester.SaveCharacter();
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void jsonCharacterTest()
        {
            SaveCharacterFile tester = new SaveCharacterFile();
            var output = tester.jsonCharacterInfo();
            Assert.AreEqual("\"character\":{\"characterName\":\"noval\",\"playerName\":\"noval\",\"race\":\"noval\",\"jobclass\":\"noval\",\"size\":\"noval\",\"alignment\":\"noval\",\"age\":\"noval\",\"deity\":\"noval\",\"gender\":\"noval\",\"height\":\"noval\",\"weight\":\"noval\",\"eyes\":\"noval\",\"hair\":\"noval\",\"homeland\":\"noval\",\"strength\":\"0\",\"dexterity\":\"0\",\"constitution\":\"0\",\"intelligence\":\"0\",\"wisdom\":\"0\",\"charisma\":\"0\",\"languages\":\"noval\",\"experiencePoints\":\"noval\"}", output);
        }

        [TestMethod]
        public void jsonCombatTest()
        {
            SaveCharacterFile tester = new SaveCharacterFile();
            var output = tester.jsonCombat();
            Assert.AreEqual("\"combat\":{\"hitPoints\":\"noval\",\"initiative\":\"noval\",\"armorClass\":\"noval\",\"fortitudeSave\":\"noval\",\"reflexSave\":\"noval\",\"willSave\":\"noval\",\"baseAttackBonus\":\"noval\",\"combatManeuverBonus\":\"noval\",\"combatManeuverDefence\":\"noval\",\"statusEffect\":\"noval\",\"encumbrance\":\"noval\",\"movement_combat\":\"noval\"}", output);
        }
    }
}
