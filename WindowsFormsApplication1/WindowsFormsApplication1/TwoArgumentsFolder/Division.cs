using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstArgument / secondArgument;
        }

    }
}
