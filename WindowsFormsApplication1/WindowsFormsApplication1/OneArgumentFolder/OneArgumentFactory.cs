using System;

namespace WindowsFormsApplication1.OneArgumentFolder
{
    public class OneArgumentFactory
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
                case "Cube": return new Cube();
                case "Reverse": return new Reverse();
                case "Module": return new Module();
                case "Inverse": return new Inverse(); 
                case "Log10": return new Log10();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}