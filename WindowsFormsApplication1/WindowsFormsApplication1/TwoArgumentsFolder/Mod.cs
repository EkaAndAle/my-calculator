using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Mod : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument%secondArgument;

        }

    }
}
