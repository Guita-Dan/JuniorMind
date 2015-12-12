using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void OneNumber()
        {
            Assert.AreEqual(5, CalculateNumberOfPossibleTickets(1, 5));
        }
        int CalculateNumberOfPossibleTickets(int nrOfChosenNumbers,int nrOfTotalNumbers)
        {
            int possibleTickets = 1;
            for (int i = nrOfTotalNumbers; i > (nrOfTotalNumbers - nrOfChosenNumbers); i--)
                   possibleTickets*=i;
            return possibleTickets;
        }
    }
}
