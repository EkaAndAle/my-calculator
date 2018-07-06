using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Finding the tangent of a number
    /// </summary>
    public class Tg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Tan(firstArgument); }

    }
}
