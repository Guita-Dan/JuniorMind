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
        string FindExcelColumnName(int columnNumber)
        {
            columnNumber = columnNumber - 1;
            string columnName = String.Empty;
            return columnName = Convert.ToChar(65 + columnNumber).ToString();
        }
    }
}
