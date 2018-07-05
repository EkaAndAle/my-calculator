using System;
namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Inverse : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}

