using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Finding the cosinus number
    /// </summary>
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Cos(firstArgument); }

    }
}
