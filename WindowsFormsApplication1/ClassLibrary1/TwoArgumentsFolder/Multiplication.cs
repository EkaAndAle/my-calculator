using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsFolder
{
    public class MultiplicationTests
    {
        [Test]
        public void Multiplication()
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(8, 7);
            // подготовительные действия
            Assert.AreEqual(56, result);
        }

    }

}
