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
        int CalculateNumberOfSquares(int numberOfRowsAndColumns)
        {
            return numberOfRowsAndColumns;
        }
    }
}
