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
        string FindCommonSubstring(string firstString, string secondString)
        {
            int index=0;
            for(int i=0; i < firstString.Length; i++)
                if(firstString[i] == secondString[i])
                {
                    index = firstString.LastIndexOf(firstString[i]) + 1;
                }
           return firstString.Substring(0, index);
        }
    }
}
