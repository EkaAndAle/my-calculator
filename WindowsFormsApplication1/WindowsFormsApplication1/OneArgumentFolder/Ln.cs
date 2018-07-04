using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Ln : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument) { return Math.Log(firstArgument); }
        
    }
}
