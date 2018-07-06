using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class PowTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(10, 2, 100)]
        [TestCase(-14, 2, 196)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Pow();
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(25, result);
        }
    }
}


