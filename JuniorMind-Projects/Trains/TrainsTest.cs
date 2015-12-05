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
        float CalculateDistance(float distantaTotala, float VitezaTren, float VitezaPasare)
        {
            float timp = (distantaTotala / 2) / (VitezaTren * 2);
            return timp * VitezaPasare;
        }
    }
}
