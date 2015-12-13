using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefixes
{
    [TestClass]
    public class Prefixes
    {
        [TestMethod]
        public void CommonPrefix()
        {
            Assert.AreEqual("aaa", FindCommonSubstring("aaab", "aaadbg"));
        }
        [TestMethod]
        public void DifferentPrefix()
        {
            Assert.AreEqual("no common prefixes", FindCommonSubstring("aaab", "baadbg"));
        }
        [TestMethod]
        public void FirstStringLonger()
        {
            Assert.AreEqual("abba", FindCommonSubstring("abbaaaaaa","abbar"));
        }
        string FindCommonSubstring(string firstString, string secondString)
        {
            int min = firstString.Length;
            if (firstString.Length > secondString.Length)
                min = secondString.Length;
            int index=0;
            for (int i = 0; i < min; i++)
                    if (firstString[i] != secondString[i])
                        break;
                    else
                        if (firstString.Length > secondString.Length)
                            index = secondString.LastIndexOf(secondString[i]);
                        else
                            index = firstString.LastIndexOf(firstString[i]);
            if (index == 0)
                return "no common prefixes";
            else
                return firstString.Substring(0, index + 1);
        }
    }
}
