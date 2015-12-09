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
        string FizzBuzz(int nr)
        {
            if (nr % 3 == 0)
                return "Fizz";
            else
                if (nr % 5 == 0)
                    return "Buzz";
            return nr.ToString();
        }
        
    }
}
