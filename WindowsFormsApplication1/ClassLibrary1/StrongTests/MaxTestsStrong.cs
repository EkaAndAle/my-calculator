using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class MaxTestStrong
    {
        [TestCase(0, 0, 0)]
        [TestCase(8, 2, 8)]
        [TestCase(64, 4, 64)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Max();
            double result = calculator.Calculate(25, 2);
            Assert.AreEqual(25, result);
        }
    }
}