using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(8, 2, 2)]
        [TestCase(64, 4, 4)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Min();
            double result = calculator.Calculate(25, 2);
            Assert.AreEqual(2, result);
        }
    }
}