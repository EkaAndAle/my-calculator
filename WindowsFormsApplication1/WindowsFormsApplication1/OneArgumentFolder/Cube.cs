using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Raising a number in a cube
    /// </summary>
    public class Cube : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Pow(firstArgument,3); }

    }
}
