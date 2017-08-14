using NUnit.Framework;
using WpfApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tests
{
    [TestFixture()]
    public class PersonTests
    {
        [Test()]
        public void PersonTest()
        {
            Person p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
            Assert.IsTrue(20 == p.Age);
        }
    }
}