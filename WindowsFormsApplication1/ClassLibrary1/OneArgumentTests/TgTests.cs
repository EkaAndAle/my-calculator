using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{
    public class TgTests
    {
        [Test]
        public void Tg()
        {
            IOneArgumentCalculator calculator = new Tg();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }

    }

}
