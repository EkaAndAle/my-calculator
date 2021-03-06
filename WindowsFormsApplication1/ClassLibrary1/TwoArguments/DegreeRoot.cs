﻿using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace ClassLibrary1.TwoArgumentsTests
{
    [TestFixture]
    public class DegreeRootTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(25, 2, 5)]
        [TestCase(36, 2, 6)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new DegreeRoot();
            double result = calculator.Calculate(64, 6);
            Assert.AreEqual(2, result);
        }
    }
}


