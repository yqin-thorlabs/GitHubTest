using CSharpLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CSharpLibMSTest //WpfApp.Tests
{
    [TestClass]
    public class PersonTests
    {
        //Mock<IPerson> _mockPerson; // OK
        Mock<Person> _mockPerson; // if use class, the property / function must be virtual
        string _info = "info...";

        [TestInitialize]
        public void Setup()
        {
            int age = 18;
            //_mockPerson = new Mock<IPerson>(); // OK
            _mockPerson = new Mock<Person>(); // if use class, the property / function must be virtual
            _mockPerson.SetupProperty(p => p.Name, "Catherine").SetupProperty(p => p.Age, 17);
            _mockPerson.Setup(p => p.GetInfo(It.IsAny<string>(), out age, ref _info));
        }

        [TestMethod]
        public void PersonMsTest()
        {
            var p = new Person("David", 20);
            Assert.AreEqual("David", p.Name);
            Assert.AreEqual(20, p.Age);
            int age = 0;
            string name = _mockPerson.Object.Name;
            Assert.AreEqual("Catherine", name);
            _mockPerson.Object.GetInfo("Catherine", out age, ref _info); 
            Assert.AreEqual("info...", _info);
            Assert.AreEqual(18, age);
        }
    }
}