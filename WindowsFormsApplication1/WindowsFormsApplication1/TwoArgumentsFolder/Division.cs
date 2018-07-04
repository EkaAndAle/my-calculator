namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument) { return firstArgument / secondArgument; }
    }
}
