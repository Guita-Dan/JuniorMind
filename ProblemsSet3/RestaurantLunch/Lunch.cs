using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantLunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void GreatestCommonDividerSecondNrGreater()
        {
            Assert.AreEqual(2, CalculateGreatestCommonDivider(4, 6));
        }
        [TestMethod]
        public void GreatestCommonDividerFirstNrGreater()
        {
            Assert.AreEqual(4, CalculateGreatestCommonDivider(8, 4));
        }
        int CalculateGreatestCommonDivider(int him, int me)
        {
            while (him != me)
            {
                if (him > me)
                    him = him - me;
                else
                    me = me - him;
            }
            return him;
        }
    }
}
