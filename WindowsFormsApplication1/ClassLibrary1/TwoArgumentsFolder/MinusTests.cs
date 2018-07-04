using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsFolder
{
    public class MinusTests
    {
        [Test]
        public void Minus()
        {
            ITwoArgumentsCalculator calculator = new WindowsFormsApplication1.TwoArgumentsFolder.Minus();
            double result = calculator.Calculate(8, 7);
            // подготовительные действия
            Assert.AreEqual(1, result);
        }

    }

}
