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
            int Watermelon = VerifyParity(10);
            Assert.AreEqual(1, Watermelon);
        }
        int VerifyParity(int WatermelonWeight)
        {
            if (WatermelonWeight % 2 == 0)
                return 1;
            else
                return 0;
        }

    }
}
