using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class CosTestStrong

    {
        [TestCase(0, 1)]
        public void CalculateCosTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}