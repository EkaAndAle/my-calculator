using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class MinusTestStrong
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(13, 26);
            Assert.AreEqual(-13, result);
        }
    }
}
