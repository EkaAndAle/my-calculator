using System;
using WindowsFormsApplication1.OneArgumentFolder;
using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.FactoryTests
{

    public class TwoArgumentFactoryTest
    {
        [TestCase("Plus", typeof(DegreeRoot))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }


    }
}
