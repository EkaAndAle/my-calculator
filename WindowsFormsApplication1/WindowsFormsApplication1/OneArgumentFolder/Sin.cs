using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Sin(firstArgument); }

    }
}
