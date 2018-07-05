using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{
    public class SinTests
    {
        [Test]
        public void Sin()
        {
            IOneArgumentCalculator calculator = new Sin() ;
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }

    }

}
