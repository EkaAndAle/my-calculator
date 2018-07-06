using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    ///  Calculating the logarithm
    /// </summary>
    public class Log : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if ((secondArgument <= 0)||(firstArgument <= 0)|| (secondArgument == 1))
            {
                throw new Exception("Невозможное значение");
            }
            return System.Math.Log(firstArgument, secondArgument);
        }
    }
}
