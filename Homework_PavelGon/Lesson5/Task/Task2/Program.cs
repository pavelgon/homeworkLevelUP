using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Program
    {
        static public void Main()
        {
            const string INPUT_COEFF =
                "Введите коэффициенты A и B линейного уравнения\r\n"+
                "разделенные запятой или пробелом";

            Coeff coeffAandB;
            
            Console.Write(INPUT_COEFF+": ");
            string coeff_A_B = Console.ReadLine();
            coeffAandB = Coeff.Parse(coeff_A_B);
            Console.WriteLine("{0}*X + {1}*Y = 0", coeffAandB.A, coeffAandB.B);
            //Console.ReadLine();
            //Console.Clear();
        }
    }
}
