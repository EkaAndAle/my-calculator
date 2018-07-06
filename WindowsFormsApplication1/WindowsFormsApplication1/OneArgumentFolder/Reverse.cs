using System;
namespace WindowsFormsApplication1.OneArgumentFolder
{
    /// <summary>
    /// Finding a number in -1 degree
    /// </summary>
    public class Reverse : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("0");
            }
            return 1/firstArgument;
        }
    }
}
