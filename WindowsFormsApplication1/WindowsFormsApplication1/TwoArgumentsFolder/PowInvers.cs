namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// The multiplication of a number by -1
    /// </summary>
    public class PowInvers : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return System.Math.Pow(firstArgument, -secondArgument); }
    }
}