using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class LnTestStrong

    {
        [TestCase(1, 0)]
        public void CalculateLnTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Ln();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
