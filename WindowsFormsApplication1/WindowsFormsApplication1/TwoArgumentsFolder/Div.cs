namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    /// <summary>
    /// Performing integer division
    /// </summary>
    public class Div : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (int)firstArgument /(int)secondArgument;
        }
    }
}
