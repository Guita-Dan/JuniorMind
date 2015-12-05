using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class TrainsTest
    {
        [TestMethod]
        public void Test1()
        {
            float distantaZburata = CalculateDistance(200, 10, 20);
            Assert.AreEqual(100, distantaZburata);
        }
        [TestMethod]
        public void Test2()
        {
            float distantaZburata = CalculateDistance(300, 20, 40);
            Assert.AreEqual(150, distantaZburata);
        }
        [TestMethod]
        public void Test3()
        {
            float distantaZburata = CalculateDistance(648, 85, 170);
            Assert.AreEqual(324, distantaZburata);
        }
        float CalculateDistance(float distantaTotala, float VitezaTren, float VitezaPasare)
        {
            distantaTotala = distantaTotala / 2; //at 1/4 of distance on both sides, remaining distance is halved
            float timp = distantaTotala / (VitezaTren * 2);
            return timp * VitezaPasare;
        }
    }
}
