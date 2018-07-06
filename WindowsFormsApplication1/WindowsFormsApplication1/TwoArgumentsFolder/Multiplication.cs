

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Multiplication of numbers
    /// </summary>
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument * secondArgument; }
    }
}
