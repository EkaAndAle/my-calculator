using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class MinTestStrong
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