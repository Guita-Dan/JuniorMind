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
        float CalculateFoodPerDayPerGoat(float days, float goats,float food)
        {
            return food / days / goats;
        }
    }
}
