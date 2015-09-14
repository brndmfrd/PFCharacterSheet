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
            Assert.AreEqual("expected", output);
        }
    }
}
