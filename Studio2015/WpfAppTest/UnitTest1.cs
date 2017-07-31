using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp;

namespace WpfAppTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CtorTest()
        {
            Person p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
        }
    }
}
