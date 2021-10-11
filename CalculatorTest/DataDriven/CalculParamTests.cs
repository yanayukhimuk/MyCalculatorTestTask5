namespace CalculatorTest.DataDriven
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    [Parallelizable]
    public class CalculParamTests
    {
        CSharpCalculator.Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new CSharpCalculator.Calculator();
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void SimpleExampleTestCase(int n, int d, int q)
        {
            Assert.That(calculator.Divide(n, d) == q);
        }

        [Test, Sequential]
        public void TestDivisionBy2(
            [Values(10, 25, 40)] int input,
            [Values(5, 12, 20)] int expectedOutput)
        {
            Assert.That(calculator.Divide(input, 2) == expectedOutput);
        }

    }
}
