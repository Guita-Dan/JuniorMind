using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTable
{
    [TestClass]
    public class Chess
    {
        [TestMethod]
        public void SquaresForOneRow()
        {
            Assert.AreEqual(1, CalculateNumberOfSquares(1));
        }
        [TestMethod]
        public void SquaresForTwoRows()
        {
            Assert.AreEqual(5, CalculateNumberOfSquares(2));
        }
        [TestMethod]
        public void SquaresForEightRows()
        {
            Assert.AreEqual(204, CalculateNumberOfSquares(8));
        }
        int CalculateNumberOfSquares(int numberOfRowsAndColumns)
        {
            if (numberOfRowsAndColumns > 1)
                return numberOfRowsAndColumns * numberOfRowsAndColumns + CalculateNumberOfSquares(numberOfRowsAndColumns - 1);
            return numberOfRowsAndColumns;

        }
    }
}
