using NUnit.Framework;
using CSharpLib;

namespace CSharpLibNUnitTest
{
    [TestFixture]
    public class PersonTests
    {
        [Test()]
        public void PersonNUnitTest()
        {
            Person p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
            Assert.IsTrue(20 == p.Age); // Assert.IsNull
            Assert.IsTrue(20 == p.Age); // Assert.AreSame
        }
    }
}
