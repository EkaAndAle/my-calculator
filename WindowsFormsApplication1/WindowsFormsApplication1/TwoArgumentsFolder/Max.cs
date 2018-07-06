using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Finding the maximum number
    /// </summary>
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < secondArgument)
                return secondArgument;
            else { return firstArgument; }

        }

    }
}

