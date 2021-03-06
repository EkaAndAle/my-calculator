﻿using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    ///  Finding the geometric mean
    /// </summary>
    public class GeomMean : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument * secondArgument, 0.5);
        }
    }
}