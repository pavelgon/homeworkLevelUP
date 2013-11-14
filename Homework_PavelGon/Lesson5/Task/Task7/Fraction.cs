using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task7
{
    class Fraction
    {
        int numerator, denomirator;

        public Fraction()
        {
            numerator = 0; denomirator = 1;
        }

        public Fraction(int num, int denom)
        {
            int temp;
            if (denom == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю. Знаменателю присвоенно значение 1");
                denomirator = 1;
                numerator = num;
            }
            else
            {
                temp = Nod(num, denom);
                if (temp != 1)
                {
                    numerator = num / temp;
                    denomirator = denom / temp;
                }
                else
                {
                    numerator = num;
                    denomirator = denom;
                }
            }
            if (denomirator < 0)
            {
                numerator = -numerator;
                denomirator = -denomirator;
            }
        }
        
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int n, d;
            n = f1.numerator * f2.denomirator + f1.denomirator * f2.numerator;
            d = f1.denomirator * f2.denomirator;
            return new Fraction(n, d);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int n, d;
            n = f1.numerator * f2.denomirator - f1.denomirator * f2.numerator;
            d = f1.numerator * f1.denomirator;
            return new Fraction(n, d);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int n, d;
            n = f1.numerator * f2.numerator;
            d = f1.denomirator * f2.denomirator;
            return new Fraction(n, d);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int n, d;
            n= f1.numerator * f2.denomirator;
            d= f1.denomirator * f2.numerator;
            return new Fraction(n, d);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (f1.numerator == f2.numerator && f1.denomirator == f2.denomirator)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction temp = obj as Fraction;
                return (this == obj);
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return ((double)numerator/denomirator).GetHashCode();
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if (f1.numerator != f2.numerator || f1.denomirator != f2.denomirator)
                return true;
            else
                return false;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            if (f1.numerator / f1.denomirator > f2.numerator / f2.denomirator)
                return true;
            else
                return false;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            if (f1.numerator / f1.denomirator < f2.numerator / f2.denomirator)
                return true;
            else
                return false;
        }

        public static bool operator true(Fraction f1)
        {
            if(f1.numerator<=f1.denomirator)
                return true;
            else
                return false;
        }

        public static bool operator false(Fraction f1)
        {
            if (f1.numerator > f1.denomirator)
                return true;
            else
                return false;
        }

        public static Fraction operator *(Fraction f1, int i)
        {
            Fraction temp = new Fraction(i, 1);
            return temp*f1;
        }

        public static Fraction operator *(int i, Fraction f1)
        {
            return f1*i;
        }

        public static Fraction operator +(Fraction f1, double numerator)
        {
            int i1 = (int)numerator;
            int denomirator = 1;
            while (i1 - numerator < 0)
            {
                denomirator *= 10;
                numerator *= 10;
                i1 = (int)numerator;
            }
            Fraction temp = new Fraction(i1, denomirator);
            return f1 + temp;

        }

        public override string ToString()
        {
            return String.Format("{0}/{1}",numerator,denomirator);
        }

        private int Nod(int a, int b)
        {

            int p = 0;
            do
            {
                p = a % b;
                a = b;
                b = p;
            } while (b!=0);
            return a;
        }
    }
}
