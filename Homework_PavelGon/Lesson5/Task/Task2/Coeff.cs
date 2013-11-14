using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public struct Coeff
    {
        private int a;
        private int b;
        int indexSeparate;

        public int A { get { return a; } }
        public int B { get { return b; } }

        static public Coeff Parse(string str)
        {
            Coeff coeff = new Coeff();
            try
            {
                IsTrueFormat(str);
                SearchIndexSeparate(str, ref coeff);
                if (coeff.indexSeparate > 0)
                {
                    coeff.a = Convert.ToInt32(str.Remove(coeff.indexSeparate));
                    coeff.b = Convert.ToInt32(str.Substring(coeff.indexSeparate + 1));
                }
                else
                    throw new FormatException("Неверный формат");
            }
            catch (FormatException fe)
            {
                coeff.a = 0;
                coeff.b = 0;
                Console.WriteLine(fe.Message);
                Console.WriteLine("a = 0; b = 0");
            }
            catch (OverflowException oe)
            {
                coeff.a = 0;
                coeff.b = 0;
                Console.WriteLine(oe.Message);
                Console.WriteLine("a = 0; b = 0");
            }
            return coeff;
        }

        static void SearchIndexSeparate(string str, ref Coeff coeff1)
        {
            if ((coeff1.indexSeparate = str.IndexOf(' ')) != -1)
                return;
            else
                coeff1.indexSeparate = str.IndexOf(',');
        }

        static void IsTrueFormat(string str)
        {
            bool flagSeparate = false;

            if (!string.IsNullOrEmpty(str) && Char.IsDigit(str[0]))
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (Char.IsDigit(str[i]))
                        continue;
                    else if ((str[i] == ' ' || str[i] == ',') && !flagSeparate && i!=(str.Length-1))
                    {
                        flagSeparate = true;
                        //indexSeparate = i; //Заменяет метод SearchIndexSeparate
                    }
                    else
                        throw new FormatException("Неверный формат данных");
                }  
            }

            if (!flagSeparate)
                throw new FormatException("Неверный формат данных");
        }

    }
}
