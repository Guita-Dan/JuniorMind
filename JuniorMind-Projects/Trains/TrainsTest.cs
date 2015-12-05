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
        float CalculateDistance(float distantaTotala, float VitezaTren, float VitezaPasare)
        {
            return (distantaTotala / 2) / (VitezaTren * 2) * VitezaPasare;
        }
    }
}
