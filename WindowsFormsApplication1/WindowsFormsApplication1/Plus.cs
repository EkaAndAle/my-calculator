

namespace WindowsFormsApplication1
{
    public class Plus: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument + secondArgument; }
    }
}
