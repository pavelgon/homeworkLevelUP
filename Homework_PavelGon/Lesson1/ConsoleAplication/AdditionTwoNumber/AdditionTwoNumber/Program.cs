using System;

namespace AdditionTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Программа по сложению двух чисел");
            Console.WriteLine();
            Console.Write("Введите первое число: a = ");
            if (!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректно введеное число.\n а присвоено значение 0");
                a = 0;
            }
            Console.WriteLine();
            Console.Write("Введите второе число: b = ");
            if (!Double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Некорректно введеное число.\n b присвоено значение 0");
                b = 0;
            }
            c = a + b;
            Console.WriteLine("Результат: {0} + {1} = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
