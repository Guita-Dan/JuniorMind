using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cubes
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TripleEightForFirstNumber()
        {
            Assert.AreEqual(true, VerifyTripleEightEnding(192));
        }
        [TestMethod]
        public void NumberWithTripleEightEnding()
        {
            Assert.AreEqual(442, CalculateNumber(2));
        }

        int CalculateNumber(int nthNumberToBeDetermined)
        {
            int numberToBeDetermined = 192 + (nthNumberToBeDetermined - 1) * 250;
            if (VerifyTripleEightEnding(numberToBeDetermined) == true)
                return numberToBeDetermined;
            else
                return 0;
        }

        bool VerifyTripleEightEnding(long numberToBeDetermined)
        {
            if (Math.Pow(numberToBeDetermined, 3) % 1000 == 888)
                return true;
            else
                return false;

        }
    }
}
