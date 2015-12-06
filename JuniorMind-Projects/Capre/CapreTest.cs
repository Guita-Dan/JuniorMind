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
        public void FoodForAnyGoats()
        {
            float foodPerGoatPerDay = CalculateFoodPerDayPerGoat(3, 4, 8);
            float foodForAnyGoats = CalculateFood(5, 9);
            Assert.AreEqual(30, foodPerGoatPerDay*foodForAnyGoats);
        }
        float CalculateFoodPerDayPerGoat(float days, float goats,float food)
        {
            return food / days / goats;
        }
        float CalculateFood(float days, float goats)
        {
            return days * goats;
        }
    }
}
