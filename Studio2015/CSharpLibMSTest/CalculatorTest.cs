using System;
using System.Collections.Generic;
using CSharpLib;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpLibMSTest
{
    [TestClass]
    public class CalculatorTest
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {

        }
        
        // csv file should use ASCII / UTF-8, not Unicode UTF-8
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void AddTest1_MSTest()
        {
            Calculator calc = new Calculator();
            int num1 = Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            var result = calc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "data#xml", DataAccessMethod.Sequential)]
        public void AddTest2_MSTest()
        {
            Calculator calc = new Calculator();
            int num1 = Convert.ToInt32(TestContext.DataRow["num1"]);
            int num2 = Convert.ToInt32(TestContext.DataRow["num2"]);
            int expected = Convert.ToInt32(TestContext.DataRow["sum"]);
            var result = calc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        // json file
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "data#xml", DataAccessMethod.Sequential)]
        public void AddTest3_MSTest()
        {
            Calculator calc = new Calculator();
            int num1 = Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            var result = calc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        // Excel file
        [TestMethod]
        //[DataSource("System.Data.OleDb", @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\Temp\GitHubTest\Studio2015\CSharpLibMSTest\data.xlsx;Extended Properties='Excel 12.0;HDR=YES'", "Sheet1$", DataAccessMethod.Sequential)]
        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\data.xlsx; Extended Properties='Excel 12.0;HDR=yes';", "Sheet1$",DataAccessMethod.Sequential)]
        [DeploymentItem(@".\data.xlsx")]
        public void AddTest4_MSTest()
        {
            Calculator calc = new Calculator();
            int num1 = Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            var result = calc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }
    }
}