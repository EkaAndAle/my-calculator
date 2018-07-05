using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class Log10 : IOneArgumentCalculator
    {
        
    public double Calculate(double firstArgument)
{
    if (firstArgument <= 0)
    {
        throw new Exception("Невозможное значение");
    }
            return Math.Log10(firstArgument);
}
}
}
