using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capre
{
    [TestClass]
    public class CapreTest
    {
        [TestMethod]
        public void FoodPerDayPerGoat()
        {
            float foodPerGoatPerDay = CalculateFoodPerDayPerGoat(1, 2, 4);
            Assert.AreEqual(2, foodPerGoatPerDay);
        }
        [TestMethod]
        public void FoodForSameGoats()
        {
            float foodPerGoatPerDay = CalculateFoodPerDayPerGoat(3, 4, 8);
            Assert.AreEqual(8, foodPerGoatPerDay*3*4);
        }
        float CalculateFoodPerDayPerGoat(float days, float goats,float food)
        {
            return food / days / goats;
        }
    }
}
