using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionsModule.Models;

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
            Assert.AreEqual("{\"Acrobatics\":0,\"Appraise\":0,\"Bluff\":0,\"Climb\":0,\"Craft\":0,\"Diplomacy\":0,\"Disable Device\":0,\"Disguise\":0,\"Escape Artist\":0,\"Fly\":0,\"Handle Animal\":0,\"Heal\":0,\"Intimidate\":0,\"Knowledge Arcana\":0,\"Knowledge Dungeoneering\":0,\"Knowledge Engineering\":0,\"Knowledge Geography\":0,\"Knowledge History\":0,\"Knowledge Local\":0,\"Knowledge Nature\":0,\"Knowledge Nobility\":0,\"Knowledge Planes\":0,\"Knowledge Religion\":0,\"Linguistics\":0,\"Perception\":0,\"Perform\":0,\"Profession\":0,\"Ride\":0,\"Sense Motive\":0,\"Sleight of Hand\":0,\"Spellcraft\":0,\"Stealth\":0,\"Survival\":0,\"Swim\":0,\"Use Magic Device\":0}", output);
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
            //SaveCharacterFile tester = new SaveCharacterFile();
            //var output = tester.jsonCombat();
            //Assert.AreEqual("\"combat\":{\"hitPoints\":\"noval\",\"initiative\":\"noval\",\"armorClass\":\"noval\",\"fortitudeSave\":\"noval\",\"reflexSave\":\"noval\",\"willSave\":\"noval\",\"baseAttackBonus\":\"noval\",\"combatManeuverBonus\":\"noval\",\"combatManeuverDefence\":\"noval\",\"statusEffect\":\"noval\",\"encumbrance\":\"noval\",\"movement_combat\":\"noval\"}", output);
        }
    }
}
