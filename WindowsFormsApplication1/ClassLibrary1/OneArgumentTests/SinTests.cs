using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class SinTests

    {
        [TestCase(0, 0)]
        [TestCase(3.141592, 0)]
        [TestCase(3.141592 / 2, 1)]
        public void CalculateSinTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Sin();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.0001);
        }
    }
}