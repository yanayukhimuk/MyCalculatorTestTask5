namespace CalculatorTest.DataDriven
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    [Parallelizable]
    public class CalculParamTests
    {
        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void SimpleExampleTestCase(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Sequential]
        public void TestDivisionBy2(
            [Values(10, 25, 40)] int input,
            [Values(5, 12, 20)] int expectedOutput)
        {
            Assert.AreEqual(expectedOutput, input / 2);
        }

        [Test]
        public void RandomTest([Random(5)] double x)
        {
            Console.WriteLine("X = " + x);
        }
    }
}
