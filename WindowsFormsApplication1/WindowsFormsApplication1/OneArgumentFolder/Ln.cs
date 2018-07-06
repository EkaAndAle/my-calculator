﻿using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Calculating the base e logarithm
    /// </summary>
    public class Ln : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Log(firstArgument); }
        
    }
}
