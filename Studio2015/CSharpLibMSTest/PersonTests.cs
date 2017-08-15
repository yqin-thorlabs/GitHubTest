using CSharpLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpLibMSTest //WpfApp.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonMsTest()
        {
            var p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
        }
    }
}