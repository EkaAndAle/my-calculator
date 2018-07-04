﻿using WindowsFormsApplication1.TwoArgumentsFolder;
using NUnit.Framework;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    [TestFixture]
    public class DivisionTestStrong
    {
        [TestCase(0, 0, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(-14, -2, 7)]
        public void CalculateAdditionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(25, 5);
            Assert.AreEqual(5, result);
        }
    }
}


