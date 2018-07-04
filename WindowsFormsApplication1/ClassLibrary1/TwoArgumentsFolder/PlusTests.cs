using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsFolder
{
    public class PlusTests
    {
        [Test]
        public void Plus()
        {
            ITwoArgumentsCalculator calculator = new Plus();
            double result = calculator.Calculate(8, 7);
            // подготовительные действия
            Assert.AreEqual(15, result);
        }

    }

}