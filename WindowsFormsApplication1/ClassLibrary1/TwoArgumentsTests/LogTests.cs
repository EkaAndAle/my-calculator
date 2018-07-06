using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(8, 2, 3)]
        [TestCase(64, 2, 6)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Log();
            double result = calculator.Calculate(25, 5);
            Assert.AreEqual(2, result);
        }
    }
}


