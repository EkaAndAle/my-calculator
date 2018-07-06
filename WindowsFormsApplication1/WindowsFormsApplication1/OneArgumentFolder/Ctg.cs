using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Finding the cotangent number
    /// </summary>
    public class Ctg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return 1/Math.Tan(firstArgument); }

    }
}
