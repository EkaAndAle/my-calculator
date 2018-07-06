using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class AverageTest
    {
        [TestCase(0, 0,0)]
        [TestCase(8, 2, 5)]
        [TestCase(64, 4, 34)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Average();
            double result = calculator.Calculate(26, 2);
            Assert.AreEqual(14, result);
        }
    }
}