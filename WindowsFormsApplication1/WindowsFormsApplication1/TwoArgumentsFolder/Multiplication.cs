

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument * secondArgument; }
    }
}
