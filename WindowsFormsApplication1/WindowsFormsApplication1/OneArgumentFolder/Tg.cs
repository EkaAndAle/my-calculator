using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Tg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Tan(firstArgument); }

    }
}
