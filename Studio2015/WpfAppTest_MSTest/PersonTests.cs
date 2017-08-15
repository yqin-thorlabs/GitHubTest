using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLib;

namespace WpfAppTest_MSTest //WpfApp.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonMSTest()
        {
            Person p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
        }
    }
}