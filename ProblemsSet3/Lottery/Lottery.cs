using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void OneNumberOutOfFive()
        {
            Assert.AreEqual((float)0.2, CalculateTotalChances(1, 5));
        }
        [TestMethod]
        public void CategoryOne()
        {
            Assert.AreEqual((float)7.1511247E-08, CalculateTotalChances(6, 49));
        }

        float CalculateTotalChances(int nrOfChosenNumbers, int nrOfTotalNumbers)
        {
            float totalChances = 1;
            for(int i = nrOfChosenNumbers; i >= 1; i--)
            {
                    totalChances = totalChances * nrOfChosenNumbers /nrOfTotalNumbers;
                    nrOfChosenNumbers--;
                    nrOfTotalNumbers--;
            }
            return totalChances;
            }
        }
    }
