using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class TgTestStrong

    {
        [TestCase(0, 0)]
        public void CalculateTgTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Tg();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}