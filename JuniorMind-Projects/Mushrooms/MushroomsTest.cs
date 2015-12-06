using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Shrooms
    {
        [TestMethod]
        public void PreciseDivisionTest()
        {
            int redMushrooms = CalculateRedMushrooms(12, 3);
            Assert.AreEqual(9, redMushrooms);
        }
        int CalculateRedMushrooms(int totalMushrooms, int NrOfTimesGreater)
        {
            return totalMushrooms - totalMushrooms / (NrOfTimesGreater + 1);
        }
    }
}
