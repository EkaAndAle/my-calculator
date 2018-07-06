using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class GeomMeanTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(8, 2, 4)]
        [TestCase(64, 4, 128)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new GeomMean();
            double result = calculator.Calculate(25, 25);
            Assert.AreEqual(25, result);
        }
    }
}