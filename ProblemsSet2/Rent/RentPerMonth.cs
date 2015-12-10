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
        decimal CalculateRentPerMonth(int RentPrice, int NumberOfDays)
        {
            return RentPrice+RentPrice*2*NumberOfDays/100;
        }
    }
}
