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
        [TestMethod]
        public void TestForNumber()
        {
            Assert.AreEqual("13", FizzBuzz(13));
        }
        string FizzBuzz(int nr)
        {
            return (nr % 3==0) ? ((nr % 5==0) ? "FizzBuzz" : "Fizz") : ((nr % 5==0) ? "Buzz" : nr.ToString());
        }
        
    }
}
