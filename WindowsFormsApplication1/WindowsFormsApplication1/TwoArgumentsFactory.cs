using System;


namespace WindowsFormsApplication1
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "Plus": return new Plus();
                case "Minus": return new Minus();
                case "Multiplication": return new Multiplication();
                case "Division": return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

