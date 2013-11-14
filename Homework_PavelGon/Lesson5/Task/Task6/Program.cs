using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    public class Program
    {
        public static Int32 Main()
        {
            try
            {
                Complex z = new Complex(1, 1);
                Complex z1;
                z1 = z - (z * z * z - 1) / (3 * z * z);
                Console.WriteLine("z1 = {0}", z1);
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
