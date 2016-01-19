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
        [TestMethod]
        public void OneStringTest()
        {
            Assert.AreEqual(1, CalculateNrOfAnagrams("a"));
        }
        [TestMethod]
        public void NrOfAnagramsWithNoRepeatedCharacters()
        {
            Assert.AreEqual(6, CalculateNrOfAnagrams("abc"));
        }
        int CalculateNrOfAnagrams(string word)
        {
            int result = 1;
            if (word.Length == 0)
                return 0;
            for (int i = 1; i <= word.Length; i++)
                result *= i;
            return result;
        }
    }
}
