using System;
namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Multiplication by -1
    /// </summary>
    public class Inverse : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}

