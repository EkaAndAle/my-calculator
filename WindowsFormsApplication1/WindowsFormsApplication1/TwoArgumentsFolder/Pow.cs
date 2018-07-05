namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Pow : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return System.Math.Pow(firstArgument,  secondArgument); }
    }
}
