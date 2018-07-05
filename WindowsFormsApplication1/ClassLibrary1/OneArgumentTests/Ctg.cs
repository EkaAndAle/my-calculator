using System;
using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.OneArgumentTests
{
    public class CtgTests
    {
        [Test]
        public void Ctg()
        {
            IOneArgumentCalculator calculator = new Ctg();
            double result = calculator.Calculate(3.141592/2);
            Assert.AreEqual(0, result, 0.00001);
        }

    }

}
