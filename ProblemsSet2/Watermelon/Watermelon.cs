using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class Watermelon
    {
        [TestMethod]
        public void ParityCheck()
        {
            string Watermelon = VerifyParity(10);
            Assert.AreEqual("Da", Watermelon);
        }
        [TestMethod]
        public void ParityCheckwithStrings()
        {
            string Watermelon = VerifyParity(19);
            Assert.AreEqual("Nu", Watermelon);
        }
        string VerifyParity(int WatermelonWeight)
        {
            if (WatermelonWeight % 2 == 0)
                return "Da";
            else
                return "Nu";
        }

    }
}
