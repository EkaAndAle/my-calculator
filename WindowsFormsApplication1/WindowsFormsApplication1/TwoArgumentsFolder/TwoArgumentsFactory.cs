﻿using System;

namespace WindowsFormsApplication1.TwoArgumentsFolder
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "Plus": return new Plus();
                case "Minus": return new Minus();
                case "Multiplication": return new Multiplication();
                case "Division": return new Division();
                case "DegreeRoot": return new DegreeRoot();
                case "Pow": return new Pow();
                case "PowInvers": return new PowInvers(); 
                case "GeomMean": return new GeomMean();
                case "Log": return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }

    
}

