using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLib;
using Moq;

namespace CSharpLibTest_NUnit
{
    [TestFixture]
    public class TeamTest
    {
        private Team _team;
        Mock<Team> _mockTeam;

        [SetUp]
        public void TestSetup()
        {
            _mockTeam = new Mock<Team>();
        }

        [TearDown]
        public void TestTearDown()
        {
        }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
