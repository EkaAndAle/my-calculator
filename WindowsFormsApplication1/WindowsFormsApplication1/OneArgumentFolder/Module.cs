using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Module : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Abs(firstArgument); }
    }
}

