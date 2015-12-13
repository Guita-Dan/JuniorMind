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
            int totalSquares=0;
            
            for (int i = 1; i <= numberOfRowsAndColumns; i++)
                 totalSquares =totalSquares + numberOfRowsAndColumns + (i - 1) * (i - 1);
            return totalSquares;

        }
    }
}
