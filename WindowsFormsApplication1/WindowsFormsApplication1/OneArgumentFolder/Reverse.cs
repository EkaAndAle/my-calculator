using System;
namespace WindowsFormsApplication1.OneArgumentFolder
{
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
