using System;
using WindowsFormsApplication1.OneArgumentFolder;
using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.FactoryTests
{

    public class TwoArgumentFactoryTest
    {
        [TestCase("Plus", typeof(Plus))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Average", typeof(Average))]
        [TestCase("Mod", typeof(Mod))]
        [TestCase("Div", typeof(Div))]
        [TestCase("Max", typeof(Max))]
        [TestCase("Min", typeof(Min))]
        [TestCase("GeomMean", typeof(GeomMean))]
        [TestCase("Log", typeof(Log))]
        [TestCase("DegreeRoot", typeof(DegreeRoot))]
        [TestCase("PowInvers", typeof(PowInvers))]
        [TestCase("Pow", typeof(Pow))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
