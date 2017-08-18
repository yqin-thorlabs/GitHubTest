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
        // NOTE:
        // 1. Although the active platform is x64 for both lib and the test projects. but the Build target in project->build MUST be set to x86.
        //    Otherwise, "microsoft.Jet.OLEDB.4.0 provider is not registered" will show up when run the test.
        // 2. Or download 64 bit Microsoft Access Database Engine (). But if office installed, it MUST be 16 bit version.
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "testcase", DataAccessMethod.Sequential)]
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
        public void AddTest3_MSTest()
        {
            // no support from MSTest. Just convert it to csv or xml and then test it
        }

        // Excel file
        // must copy the excel file to the test dll folder
        [TestMethod]
        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\data.xlsx; Extended Properties='Excel 12.0;HDR=yes';", "Sheet1$", DataAccessMethod.Sequential)]
        public void AddTest4_MSTest()
        {
            Calculator calc = new Calculator();
            int num1 = Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            var result = calc.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        // TODO - use SQL Express for data source
        [TestMethod]
        //[DataSource("System.Data.SqlClient", "Data Source=.\\sqlexpress;Initial Catalog=tempdb;Integrated Security=True","Data", DataAccessMethod.Sequential)]
        // https://www.linkedin.com/pulse/visual-studio-mstest-data-injection-john-peters
        public void AddTest5_MSTest()
        {
            //throw(new NotImplementedException());
        }
    }
}