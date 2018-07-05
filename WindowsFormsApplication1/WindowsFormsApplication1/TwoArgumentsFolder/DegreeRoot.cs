
using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class DegreeRoot : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument <=0)
            {
                throw new Exception("Степень меньше или равна 0");
            }
            return System.Math.Pow(firstArgument , 1/secondArgument);
        }
    }
}
