using NUnit.Framework;
using CSharpLib;
using Moq;

namespace CSharpLibNUnitTest
{
    [TestFixture]
    public class PersonTests
    {
        Mock<IPerson> _mockPerson;
        string _info1 = "info-1";
        string _info2 = "info-2";
        string _info3 = "info-3";

        [SetUp]
        public void TestSetup()
        {
            int age;
            _mockPerson = new Mock<IPerson>();
            _mockPerson.SetupProperty(p => p.Name, "Catherine").SetupProperty(p => p.Age, 17);
            _mockPerson.Setup(p => p.GetInfo()).Returns(true);
            _mockPerson.Setup(p => p.GetInfo(out _info1));
            age = 2;
            _mockPerson.Setup(p => p.GetInfo(out age, ref _info2));
            age = 3;
            _mockPerson.Setup(p => p.GetInfo(It.IsAny<string>(), out age, ref _info3));
        }

        [TearDown]
        public void TestTearDown()
        {
        }

        [Test()]
        public void PersonNUnitTest()
        {
            Person p = new Person("David", 20);
            Assert.IsNotNull(p);
            Assert.IsNotEmpty(p.Name);
            Assert.IsNotNull(p.Name);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
            Assert.Positive(p.Age);
            Assert.Greater(p.Age, 10);
            Assert.That(p.Age, Is.EqualTo(20));
            Assert.IsTrue(20 == p.Age);
            Assert.IsTrue(_mockPerson.Object.GetInfo());
            Assert.AreEqual("Catherine", _mockPerson.Object.Name);
            Assert.AreEqual(17, _mockPerson.Object.Age);
            string name = string.Empty;
            int age = 0;
            _info1 = string.Empty;
            _mockPerson.Object.GetInfo(out _info1); // info = "info-1"
            Assert.AreEqual("info-1", _info1);
            // Only matches if the ref argument to the invocation is the same instance
            _info2 = string.Empty;
            _mockPerson.Object.GetInfo(out age, ref _info2); // age=0; info = ""; 
            Assert.AreEqual(0, age);
            Assert.AreEqual(string.Empty, _info2);
            _mockPerson.Object.GetInfo(name, out age, ref _info3); // age=3; info = "info-3"
            Assert.AreEqual(3, age);
            Assert.AreEqual("info-3", _info3);
        }
    }
}
