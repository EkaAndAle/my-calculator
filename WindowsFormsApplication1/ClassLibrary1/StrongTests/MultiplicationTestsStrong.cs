using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class MultiplicationTestStrong
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(3, 26);
            Assert.AreEqual(78, result);
        }
    }
}

