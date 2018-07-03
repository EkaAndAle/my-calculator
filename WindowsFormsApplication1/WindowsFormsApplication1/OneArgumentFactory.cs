using System;


namespace WindowsFormsApplication1
{
    class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin": return new Sin();
                case "Cos": return new Cos();
                case "Tg": return new Tg();
                case "Ctg": return new Ctg();
                case "Ln": return new Ln();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}