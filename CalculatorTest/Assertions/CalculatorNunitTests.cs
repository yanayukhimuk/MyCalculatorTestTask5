using NUnit.Framework;
using System;

namespace CalculatorTest.Assertions
{
    [TestFixture]
    [Parallelizable]
    public class CalculatorTests
    {
       CSharpCalculator.Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [Test]
        public void TestSum1()
        {
            Assert.That(calculator.Add(5, 5) == 10);
        }

        [Test]
        public void TestSum2()
        {
            Assert.That(calculator.Add(5, -5) == 0);
        }

        [Test]
        public void TestSum3()
        {
            Assert.That(calculator.Add(-5, -5) == -10);
        }
        [Test]
        public void TestSubstr1()
        {
            Assert.That(calculator.Sub(-5, -5) == 0);
        }

        [Test]
        public void TestSubstr2()
        {
            Assert.That(calculator.Sub(-5, 5) == -10);
        }

        [Test]
        public void TestSubstr3()
        {
            Assert.That(calculator.Sub(5, -5) == 10);
        }

        [Test]
        public void TestDivide1()
        {
            Assert.That(calculator.Divide(5, 5) == 1);
        }

        [Test]
        public void TestDivide2()
        {
            Assert.That(calculator.Divide(5, 1) == 5);
        }

        [Test]
        public void TestMult1()
        {
            Assert.That(calculator.Multiply(5, 0) == 0);
        }

        [Test]
        public void TestMult2()
        {
            Assert.That(calculator.Multiply(5, 5) == 25);
        }

        [Test]
        public void TestMult3()
        {
            Assert.That(calculator.Multiply(5, -5) == -25);
        }

        [Test]
        public void TestMult4()
        {
            Assert.That(calculator.Multiply(-5, -5) == 25);
        }

        [TearDown]

        public void TestClean()
        {
            Console.WriteLine("Finish Tests!");
        }
    }
}