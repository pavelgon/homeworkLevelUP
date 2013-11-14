using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2;

namespace Task3
{
    class LinearEquation
    {
        private int a1, a2, b1, b2;

        public int A1 { get { return a1; } }
        public int B1 { get { return b1; } }
        public int A2 { get { return a2; } }
        public int B2 { get { return b2; } }

        public LinearEquation()
        {
            a1 = a2 = b1 = b2 = 0;
        }

        public LinearEquation(int a1, int b1, int a2, int b2)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b1 = b1;
            this.b2 = b2;
        }
        
        public void setEquationA1_and_B1()
        {
            Coeff coeff;
            Console.Write("Введите коэффициенты A и B первого линейного уравнения\r\n"
                           + "разделенные запятой или пробелом: ");
            string coeff_A_B = Console.ReadLine();
            coeff = Coeff.Parse(coeff_A_B);
            a1 = coeff.A;
            b1 = coeff.B;
        }

        public void setEquationA2_and_B2()
        {
            Coeff coeff;
            Console.Write("Введите коэффициенты A и B второго линейного уравнения\r\n"
                           + "разделенные запятой или пробелом: ");
            string coeff_A_B = Console.ReadLine();
            coeff = Coeff.Parse(coeff_A_B);
            a2 = coeff.A;
            b2 = coeff.B;
        }

        public void SolutionEquation(out int? x, out int? y)
        {
            x = y = null;
            if ((a1 * b2 - b1 * a2) != 0)
                x = y = 0;
            else
            {
                throw new ArgumentOutOfRangeException("","Бесконечное множество решений");
            }
        }
    }
}
