using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
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

