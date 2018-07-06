using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Finding the minimum number
    /// </summary>
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if(firstArgument > secondArgument)
                return secondArgument;
            else { return firstArgument; }
                
        }

    }
}

