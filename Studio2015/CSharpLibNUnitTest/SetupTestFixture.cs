using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CSharpLibTest_NUnit
{
    [SetUpFixture]
    public class SetupTestFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // TODO: Add code here that is run before
            //  all tests in the assembly are run            
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
        }
    }
}