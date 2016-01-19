using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagram
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            Assert.AreEqual(0, CalculateNrOfAnagrams(""));
        }
        int CalculateNrOfAnagrams(string word)
        {
                return 0;
        }
    }
}
