using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Cube : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Pow(firstArgument,3); }

    }
}
