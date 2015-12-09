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
            double determinant = WidthOfSecondField * WidthOfSecondField + 4 * TotalArea;
            return (-WidthOfSecondField + Math.Sqrt(determinant)) / 2;
        }

    }
}
