using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class ModTests
    {
        [TestCase(5, 2, 1)]
        [TestCase(8, 2, 0)]
        [TestCase(64, 4, 0)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Mod();
            double result = calculator.Calculate(25, 2);
            Assert.AreEqual(1, result);
        }
    }
}