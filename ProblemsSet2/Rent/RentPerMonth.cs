using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class RentPerMonth
    {
        [TestMethod]
        public void CalculateRentForMaximumTenDaysPenalty()
        {
            Assert.AreEqual(104, CalculateRentPerMonth(100, 2));
        }
        [TestMethod]
        public void CalculateRentForElevenToThirtyDaysPenalty()
        {
            Assert.AreEqual(175, CalculateRentPerMonth(100, 15));
        }
        [TestMethod]
        public void CalculateRentForElevenThirtyToFourtyDaysPenalty()
        {
            Assert.AreEqual(500, CalculateRentPerMonth(100, 40));
        }
        decimal CalculateRentPerMonth(int RentPrice, int NumberOfDays)
        {
            if(NumberOfDays>10&&NumberOfDays<=30)
                return RentPrice + (RentPrice * 5 * NumberOfDays) / 100;
            if(NumberOfDays > 30 && NumberOfDays <= 40)
                return RentPrice + (RentPrice * 10 * NumberOfDays) / 100;
            return RentPrice+RentPrice*2*NumberOfDays/100;
        }
    }
}
