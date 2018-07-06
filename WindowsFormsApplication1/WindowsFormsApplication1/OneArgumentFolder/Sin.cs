using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Finding the sinus of a number
    /// </summary>
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Sin(firstArgument); }

    }
}
