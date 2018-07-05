using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{
    public class LnTests
    {
        [Test]
        public void Ln()
        {
            IOneArgumentCalculator calculator = new Ln();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }

    }

}

