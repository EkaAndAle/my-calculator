using System;
using WindowsFormsApplication1.OneArgumentFolder;
using NUnit.Framework;

namespace ClassLibrary1.FactoryTests
{

    public class OneArgumentFactoryTest
    {
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Tg", typeof(Tg))]
        [TestCase("Ctg", typeof(Ctg))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("Module", typeof(Module))]
        [TestCase("Inverse", typeof(Inverse))]
        [TestCase("Reverse", typeof(Reverse))]
        [TestCase("Cube", typeof(Cube))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

        
    }
}

