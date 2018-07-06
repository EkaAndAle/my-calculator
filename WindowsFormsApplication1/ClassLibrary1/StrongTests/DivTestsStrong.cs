using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class DivTestStrong
    {
        [TestCase(5, 2, 2)]
        [TestCase(8, 2, 4)]
        [TestCase(64, 4, 8)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Div();
            double result = calculator.Calculate(25, 2);
            Assert.AreEqual(12, result);
        }
    }
}