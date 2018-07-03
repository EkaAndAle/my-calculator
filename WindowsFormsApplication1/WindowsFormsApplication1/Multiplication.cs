

namespace WindowsFormsApplication1
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument * secondArgument; }
    }
}
