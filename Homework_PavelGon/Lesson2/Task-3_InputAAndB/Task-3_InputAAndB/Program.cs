using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3_InputAAndB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите число a");
            a = CheckNumber();
            Console.WriteLine("Введите число b");
            b = CheckNumber();
            if (a < b)
            {
                for (; a <= b; a++)
                {
                    for (int i = 0; i < Math.Abs(a); i++)
                        Console.Write(a + " ");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("a больше или равно b. Это протеворечит условию задачи. Программа завершена");
            Console.ReadLine();
        }

        private static int CheckNumber()
        {
            int a;
            bool check = false;
            do
            {
                if(Int32.TryParse(Console.ReadLine(), out a))
                    check = true;
                else
                {
                    Console.WriteLine("Неверный ввод. Повторите попытку");
                    check = false;
                }
            } while (!check);
            return a;
        }
    }
}
