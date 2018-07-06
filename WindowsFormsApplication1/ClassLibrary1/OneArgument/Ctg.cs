using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class CtgTests

    {
        [TestCase(3.141592 / 2, 0)]
        [TestCase(3.141592 / 4, 1)]
        [TestCase(3*3.141592 / 4, -1)]
        public void CalculateCtgTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Ctg();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}