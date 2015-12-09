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
        string FizzBuzz(int nr)
        {
            if (nr % 3 == 0)
                    return "Fizz";
            return nr.ToString();
        }
        
    }
}
