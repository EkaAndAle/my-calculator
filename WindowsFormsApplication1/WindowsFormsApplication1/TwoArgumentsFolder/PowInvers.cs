namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class PowInvers : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return System.Math.Pow(firstArgument, -secondArgument); }
    }
}