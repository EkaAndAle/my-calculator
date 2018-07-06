using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    ///Finding the remainder of the division
    /// </summary>
    public class Mod : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument%secondArgument;

        }

    }
}
