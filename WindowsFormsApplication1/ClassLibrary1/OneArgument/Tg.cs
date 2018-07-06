using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class TgTests

    {
        [TestCase(0, 0)]
        [TestCase(3.1415/4, 1)]
        [TestCase(3.1415, 0)]
        public void CalculateTgTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Tg();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.001);
        }
    }
}