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
            Assert.AreEqual(155, CalculateRentPerMonth(100, 15));
        }
        decimal CalculateRentPerMonth(int RentPrice, int NumberOfDays)
        {
            if(NumberOfDays>10&&NumberOfDays<30)
                return RentPrice + (RentPrice * 5 * NumberOfDays)/100 -20;
            return RentPrice+RentPrice*2*NumberOfDays/100;
        }
    }
}
