using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class Log10TestStrong

    {
        [TestCase(100, 2)]
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        public void CalculateReverseTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Log10();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}

