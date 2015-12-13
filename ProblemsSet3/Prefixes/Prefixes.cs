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
        string FindCommonSubstring(string firstString, string secondString)
        {
            int index=0;
            for (int i = 0; i < firstString.Length; i++)
                if (firstString[i] != secondString[i])
                    break;
                else
                    index = firstString.LastIndexOf(firstString[i]) + 1;
            if (index == 0)
                return "no common prefixes";
            else
                return firstString.Substring(0, index);
        }
    }
}
