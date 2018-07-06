using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    ///Calculating the Number Module
    /// </summary>
    public class Module : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Abs(firstArgument); }
    }
}

