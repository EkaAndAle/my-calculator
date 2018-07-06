using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Plus();
            double result = calculator.Calculate(13, 26);
            Assert.AreEqual(39, result);
        }
    }
}
