using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Cos(firstArgument); }

    }
}
