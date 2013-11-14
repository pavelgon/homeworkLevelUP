using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            
            int? x, y;
            LinearEquation equtions = new LinearEquation();
            equtions.setEquationA1_and_B1();
            equtions.setEquationA2_and_B2();
            try
            {
                equtions.SolutionEquation(out x, out y);
                Console.WriteLine("Уравнение вида:\r\n"+
                    "{0}*x + {1}*y = 0\r\n"+
                    "{2}*x + {3}*y = 0\r\n"+
                    "Ответ: x = {4}, y = {5}",
                    equtions.A1, equtions.B1, equtions.A2, equtions.B2, x, y);
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                Console.WriteLine("Уравнение вида:\r\n" +
                    "{0}*x + {1}*y = 0\r\n" +
                    "{2}*x + {3}*y = 0",
                    equtions.A1, equtions.B1, equtions.A2, equtions.B2);
                Console.WriteLine(argEx.Message);
            }
            //Console.ReadLine();
        }
    }
}
