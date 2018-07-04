using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsFolder
{
    public class DivisionTests
    {
        [Test]
        public void Division()
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(10,2);
            // подготовительные действия
            Assert.AreEqual(5, result);
        }

    }

}
