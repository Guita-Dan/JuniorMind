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
        [TestMethod]
        public void TestForAnyNumber()
        {
            int redMushrooms = CalculateRedMushrooms(17, 8);
            Assert.AreEqual(0, redMushrooms);
        }
        int CalculateRedMushrooms(int totalMushrooms, int NrOfTimesGreater)
        {
            if (totalMushrooms % (NrOfTimesGreater+1)==0)
            {
                int WhiteMushrooms = totalMushrooms / (NrOfTimesGreater + 1);
                return totalMushrooms - WhiteMushrooms;
            }
            else
                return 0;
            
        }
    }
}
