using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{
    public class CosTests
    {
        [Test]
        public void Cos()
        {
            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }

    }

}
