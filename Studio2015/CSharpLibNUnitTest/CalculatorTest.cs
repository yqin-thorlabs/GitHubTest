using System;
using System.Collections.Generic;
using CSharpLib;
using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace CSharpLibTest_NUnit
{
    [TestFixture]
    public class CalculatorTest
    {
        private ICalculator _sut;

        public static List<List<int>> TestCases
        {
            get
            {
                var testCases = new List<List<int>>();

                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                string path = Path.GetDirectoryName(codeBase);
                if (path != null)
                {
                    path = Path.Combine(path, @"data.csv");
                    path = new Uri(path).LocalPath;
                    using (var fs = File.OpenRead(path))
                    {
                        using (var sr = new StreamReader(fs))
                        {
                            string line = string.Empty;
                            while (line != null)
                            {
                                line = sr.ReadLine();
                                if (line != null)
                                {
                                    string[] split = line.Split(new[] { ',' }, StringSplitOptions.None);

                                    int num1 = Convert.ToInt32(split[0]);
                                    int num2 = Convert.ToInt32(split[1]);
                                    int resultAdd = Convert.ToInt32(split[2]);
                                    int resultMul = Convert.ToInt32(split[3]);

                                    List<int> testCase = new List<int>();
                                    testCase.Add(num1);
                                    testCase.Add(num2);
                                    testCase.Add(resultAdd);
                                    testCase.Add(resultMul);
                                    testCases.Add(testCase);
                                }
                            }
                        }
                    }
                }

                return testCases;
            }
        }

        //[OneTimeSetUp]
        [SetUp]
        public void TestSetup()
        {
            _sut = new Calculator();
        }

        //[OneTimeTearDown]
        [TearDown]
        public void TestTearDown()
        {
            _sut = null;
        }

        public void MulTest()
        {
            var expectedResult = _sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [TestCase(2,3)]
        [TestCase(3,4)]
        public void AddTest1(int num1, int num2)
        {
            var expectedResult = _sut.Add(num1, num2);
            Assert.That(expectedResult, Is.EqualTo(num1 + num2));
        }

        private static readonly int[][] Numbers = { new[] { 4, 5 }, new[] { 6, 7 } };
        [TestCaseSource(nameof(Numbers))]
        public void AddTest2(int[] num)
        {
            var expectedResult = _sut.Add(num[0], num[1]);
            Assert.That(expectedResult, Is.EqualTo(num[0] + num[1]));
        }

        [TestCaseSource(nameof(TestCases))]
        public void AddTest3(List<int> num)
        {
            var expectedResult = _sut.Add(num[0], num[1]);
            Assert.That(expectedResult, Is.EqualTo(num[2]));
        }
    }
}