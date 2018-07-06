using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class CubeTestStrong

    {
        [TestCase(3 , 27)]
        [TestCase(2, 8)]
        [TestCase(1, 1)]
        public void CalculateCtgTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Cube();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
