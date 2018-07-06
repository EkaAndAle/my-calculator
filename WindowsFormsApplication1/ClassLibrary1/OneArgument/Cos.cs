using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class CosTests

    {
        [TestCase(0, 1)]
        [TestCase(3.141592, -1)]
        [TestCase(3.141592/2, 0)]
        public void CalculateCosTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.00001);
        }
    }
}