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
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

        
    }
}

