using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Finding the average of arithmetic numbers
    /// </summary>
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
             return (firstArgument+ secondArgument)/2; 

        }

    }
}
