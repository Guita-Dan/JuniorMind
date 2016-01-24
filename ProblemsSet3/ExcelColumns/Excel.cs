using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void SingleLetterTest()
        {
            Assert.AreEqual("A", FindExcelColumnName(1));
        }
        [TestMethod]
        public void DoubleLetterTest()
        {
            Assert.AreEqual("AB", FindExcelColumnName(28));
        }
        string FindExcelColumnName(int columnNumber)
        {
            int modulo;
            string columnName = String.Empty;
            while (columnNumber > 0)
            {
                modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                columnNumber = (int)(columnNumber - modulo) / 26;
            }
            return columnName;
        }
    }
}
