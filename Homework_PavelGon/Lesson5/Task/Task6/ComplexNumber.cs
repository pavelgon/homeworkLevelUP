using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Complex
    {
        double x, y;

        public Complex()
        {
            x = y = 0;
        }

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            if (x == 0 && y != 0)
                return String.Format("{0}*i",y);
            else if (x != 0 && y == 0)
                return String.Format("{0}", x);
            else if (x == 0 && y == 0)
                return String.Format("0");
            else
                return String.Format("{0} + ({1}*i)", x, y);
        }

        static public Complex operator *(Complex z, Complex z1)
        {
            Complex temp = new Complex();
            temp.x = z.x * z1.x - z.y * z1.y;
            temp.y = z.y * z1.x + z.x * z1.y;
            return temp;
        }
        static public Complex operator *(int i, Complex z)
        {
            Complex temp = new Complex(i, 0);
            return temp*z;
        }

        static public Complex operator /(Complex z, Complex z1)
        {
            Complex temp = new Complex();
            temp.x = (z.x * z1.x + z.y * z1.y) / (z1.x * z1.x + z1.y * z1.y);
            temp.y = (z.y * z1.x - z.x * z1.y) / (z1.x * z1.x + z1.y * z1.y);
            return temp;
        }

        static public Complex operator -(Complex z, int i)
        {
            Complex temp = new Complex();
            temp.x = z.x - i;
            temp.y = z.y;
            return temp;
        }
        static public Complex operator -(Complex z, Complex z1)
        {
            Complex temp = new Complex();
            temp.x = z.x - z1.x;
            temp.y = z.y - z1.y;
            return temp;
        }
    }
}
