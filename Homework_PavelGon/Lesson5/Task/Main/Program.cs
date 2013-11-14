using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            #region field
            const string LESSON = "Занятие-5. Домашнее задание";
            const string INPUT = "Введите пункт меню: ";
            const string TASK_1 = "1. Разработать собственный структурный тип данных для хранения целочисленных коэффициентов A и B линейного уравнения A*X + B*Y = 0";
            const string TASK_2 = "2. Разработать метод для решения системы 2 линейных уравнений: \r\nA1*X + B1*Y = 0; \r\nA2*X + B2*Y = 0";
            const string TASK_3 = "3. Разработайте приложение “7 чудес света”, где каждое чудо будет представлено отдельным классом";
            const string TASK_4 = "4. Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран";
            const string TASK_5 = "5. Реализовать класс для хранения комплексного числа";
            const string TASK_6 = "6. Разработать класс Fraction, представляющий простую дробь";
            const string EXIT = "7. Выход";

            bool flag = false;
            #endregion
            
            do
            {
                Console.WriteLine(LESSON);
                Console.WriteLine(TASK_1+ "\r\n");
                Console.WriteLine(TASK_2+"\r\n");
                Console.WriteLine(TASK_3+ "\r\n");
                Console.WriteLine(TASK_4+ "\r\n");
                Console.WriteLine(TASK_5+ "\r\n");
                Console.WriteLine(TASK_6+ "\r\n");
                Console.WriteLine(EXIT+"\r\n");
                Console.Write(INPUT);
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(TASK_1);
                        Task2.Program.Main();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(TASK_2);
                        Task3.Program.Main();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(TASK_3);
                        Task4.Program.Main();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine(TASK_4);
                        Task5.Program.Main();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(TASK_5);
                        Task6.Program.Main();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine(TASK_6);
                        Task7.Program.Main();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Выход из программы");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Такого пункта не существует");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (!flag);

        }




    }
}
