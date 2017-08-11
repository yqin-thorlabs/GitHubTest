using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp;

namespace WpfAppTest_NUnit
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CtorTest()
        {
            Person p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
        }
    }
}
