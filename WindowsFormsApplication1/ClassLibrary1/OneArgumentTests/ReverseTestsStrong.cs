using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class ReverseTestStrong

    {
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        [TestCase(8, 0.125)]
        public void CalculateReverseTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Reverse();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
