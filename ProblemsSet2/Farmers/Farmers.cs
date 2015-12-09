using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateInitialAreaOfField()
        {
            Assert.AreEqual(4, CalculateInitialAreaOfField(10, 3));
        }
        double CalculateInitialAreaOfField(int TotalArea, int WidthOfSecondField)
        {
            double determinant = WidthOfSecondField * WidthOfSecondField + 4 * TotalArea;
            double Length = (-WidthOfSecondField + Math.Sqrt(determinant)) / 2; ;
            
            return Length * Length;
        }

    }
}
