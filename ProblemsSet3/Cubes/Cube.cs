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
        bool VerifyTripleEightEnding(long number)
        {
            if(Math.Pow(number, 3) % 1000 == 888)
                return true;
            else
                return false;
                    
        }
    }
}
