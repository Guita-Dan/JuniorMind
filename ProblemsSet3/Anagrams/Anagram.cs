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
        [TestMethod]
        public void AnagramsWithOneRepeatedChar()
        {
            Assert.AreEqual(3, CalculateNrOfAnagrams("aab"));
        }
        [TestMethod]
        public void AnagramsWithMoreRepeatedChar()
        {
            Assert.AreEqual(12600, CalculateNrOfAnagrams("aaaabbbccd"));
        }

        int CalculateNrOfAnagrams(string word)
        {
            int result;
            if (word.Length == 0)
                return 0;
            result = CalculateFactorial(word.Length) / CountOfRepeatedChars(word);
            return result;
        }

        int CountOfRepeatedChars(string inputstring)
        {
            int result = 0;
            int p = 1;
            for (char charToCheck = 'a'; charToCheck <= 'z'; charToCheck++)
            {
                result = CountOfChars(inputstring, charToCheck);
                p *= CalculateFactorial(result);
            }
            return p;
        }

        private static int CountOfChars(string inputstring, char charToCheck)
        {
            int result = 0;
            for (int i = 0; i < inputstring.Length; i++)
            {
                if (inputstring[i] == charToCheck)
                {
                    result++;
                }
            }
            return result;
        }


        private static int CalculateFactorial(int length)
        {
            int result = 1;
            for (int i = 1; i <= length; i++)
                result *= i;
            return result;
        }
    }
}
