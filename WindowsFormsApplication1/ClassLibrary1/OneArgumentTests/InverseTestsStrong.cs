using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class InverseTestStrong

    {
        [TestCase(2, -2)]
        [TestCase(-2, 2)]
        [TestCase(8, -8)]
        public void CalculateReverseTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Inverse();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
