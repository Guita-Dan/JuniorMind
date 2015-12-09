using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFizz()
        {
            Assert.AreEqual("Fizz", FizzBuzz(9));
        }
        [TestMethod]
        public void TestForBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzz(10));
        }
        [TestMethod]
        public void TestForFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz(15));
        }
        string FizzBuzz(int nr)
        {
            if (nr % 3 == 0 && nr % 5 == 0)
                return "FizzBuzz";
            if (nr % 3 == 0)
                return "Fizz";
            if (nr % 5 == 0)
                return "Buzz";
            return nr.ToString();
        }
        
    }
}
