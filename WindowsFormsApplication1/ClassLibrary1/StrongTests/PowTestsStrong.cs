using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class PowTestStrong
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


