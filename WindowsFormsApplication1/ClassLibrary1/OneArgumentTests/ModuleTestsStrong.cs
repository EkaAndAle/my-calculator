using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{

    [TestFixture]
    public class ModuleTestStrong

    {
        [TestCase(-2, 2)]
        [TestCase(-6, 6)]
        [TestCase(25, 25)]
        public void CalculateReverseTestStrong(double firstValue, double expected)
        {


            IOneArgumentCalculator calculator = new Module();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}

