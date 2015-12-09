using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateIntialLengthForSquare()
        {
            Assert.AreEqual(2, CalculateInitialLength(10, 3));
        }
        double CalculateInitialLength(int TotalArea, int WidthOfSecondField)
        {
            return (-WidthOfSecondField + Math.Sqrt(WidthOfSecondField * WidthOfSecondField + 4 * TotalArea)) / 2;
        }
       

    }
}
