namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Exponentiation
    /// </summary>
    public class Pow : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return System.Math.Pow(firstArgument,  secondArgument); }
    }
}
