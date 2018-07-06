using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class LnTestStrong

    {
        [TestCase(1, 0)]
        [TestCase(2.718, 1)]
        [TestCase(7.389, 2)]
        public void CalculateLnTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Ln();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.001);
        }
    }
}
