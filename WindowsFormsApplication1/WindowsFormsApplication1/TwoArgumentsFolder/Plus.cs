

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Plus: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument + secondArgument; }
    }
}
