using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task7
{
    public class Program
    {
        public static int Main()
        {
            try
            {
                Fraction f = new Fraction(3, 4);
                Console.WriteLine("Задана дробь {0}", f);
                int a = 10;
                Fraction f1 = f * a;
                Console.WriteLine("{0} * {1} = {2}", f, a, f1);
                Fraction f2 = a*f;
                Console.WriteLine("{0} * {1} = {2}", a, f, f2);
                double d = 1.5;
                Fraction f3 = f + d;
                Console.WriteLine("{0} + {1} = {2}", f, d, f3);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
