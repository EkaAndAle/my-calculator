using System;

namespace WindowsFormsApplication1
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Sin(firstArgument); }

    }
}
