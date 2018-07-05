namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class Div : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (int)firstArgument /(int)secondArgument;
        }
    }
}
