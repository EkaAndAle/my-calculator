using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class PowInverseTests
    {
      
        [TestCase(100, 2, 10)]
        [TestCase(25, 2, 5)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}



