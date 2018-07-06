using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Division of numbers
    /// </summary>
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
