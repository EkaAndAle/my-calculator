

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Subtraction of numbers
    /// </summary>
    public class Minus : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument - secondArgument; }
    }
}
