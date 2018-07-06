

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Addition of numbers
    /// </summary>
    public class Plus: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument + secondArgument; }
    }
}
