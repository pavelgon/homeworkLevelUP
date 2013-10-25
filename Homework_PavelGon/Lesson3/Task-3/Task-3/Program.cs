using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
    class Program
    {
        // Домашняя работа. Урок 3.
        static void Main()
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Домашняя работа. Урок 3");
                Console.WriteLine("Введите номер пункта меню для запуска нужной программы или выхода из меню:\r\n" +
                    "1  Программа, проверяющая число на четность;\r\n" +
                    "2  Программа, выводящая на экран количество цифр в числе и сумму этих цифр;\r\n" +
                    "3  Конвертер, переводящий дюймы в сантиметры и наоборот;\r\n" +
                    "4  Программа выводит на экран линию из символов;\r\n" +
                    "5  Программа находит сумму всех целых нечетных чисел в диапазоне;\r\n" +
                    "6  Программа вычисляет факториал натуральных целых чисел n\r\n" +
                    "7  Программа для вывода заполненного квадрата 10х10\r\n" +
                    "8  Программа для вывода пустого квадрата 10х10\r\n" +
                    "9  Программа для вывода заполненного треукольника 10х10x10\r\n" +
                    "10 Программа для вывода пустого треукольника 10х10x10\r\n" +
                    "11 Программа для вывода заполненного ромба 5х5x5х5\r\n" +
                    "12 Программа для вывода пустого ромба 5х5x5х5\r\n" +
                    "13 Выход из меню");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        EvenParity();
                        break;
                    case "2":
                        Console.Clear();
                        NumberDigitsAndSum();
                        break;
                    case "3":
                        Console.Clear();
                        ConverterInchAndCentimetre();
                        break;
                    case "4":
                        Console.Clear();
                        Line();
                        break;
                    case "5":
                        Console.Clear();
                        SumOddNumbers();
                        break;
                    case "6":
                        Console.Clear();
                        Factorial();
                        break;
                    case "7":
                        Console.Clear();
                        SquareFill();
                        break;
                    case "8":
                        Console.Clear();
                        SquareEmpty();
                        break;
                    case "9":
                        Console.Clear();
                        TriangleFill();
                        break;
                    case "10":
                        Console.Clear();
                        TriangleEmpty();
                        break;
                    case "11":
                        Console.Clear();
                        RhombFill();
                        break;
                    case "12":
                        Console.Clear();
                        RhombEmpty();
                        break;
                    case "13":
                        exit = true;
                        Console.WriteLine("Программа завершена. Нажмите Enter.");
                        break;
                    default:
                        Console.WriteLine("Выбранного пункта в меню не существует");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (!exit);
        }

        /*
        Задача-1.
        Условие:
            Напишите программу, проверяющую число, введенное с клавиатуры на четность.
        */
        static void EvenParity()
        {
            int number;
            Console.WriteLine("Программа, проверяющая число, введенное с клавиатуры на четность");
            Console.Write("Введите целое число: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число {0} четное", number);
            else
                Console.WriteLine("Число {0} нечетное", number);
        }

        /*
        Задача-2.
        Условие:
            Дано натуральное число а (a<100). Напишите программу, выводящую на экран количество цифр в этом числе и сумму этих цифр
        */
        static void NumberDigitsAndSum()
        {
            int count=0, sum = 0, numberInput, number;
            bool flag;
            string ending;
            Console.WriteLine("Программа, выводящая на экран количество цифр в веденном числе и сумму этих цифр");
            Console.Write("Введите натуральное число меньше 100: ");
            do
            {
                numberInput = Convert.ToInt32(Console.ReadLine());
                if (numberInput < 100 && numberInput > 0)
                    flag = false;
                else
                {
                    flag = true;
                    Console.WriteLine("Число выходит за требуемый диапазон, повторите попытку");
                    Console.Write("Введите натуральное число меньше 100: ");
                }
            } while (flag);
            
            number = numberInput;
            
            do
            {
                sum += number % 10;
                number /= 10;
                count++;
            } while (number>=1);
            
            switch (count)
            {
                case 1: ending = "у";
                    break;
                case 2: ending = "ы";
                    break;
                default:
                    ending = "";
                    break;
            }
            
            Console.WriteLine("Число {0} имеет {1} цифр{3} и их сумма составляет {2}", numberInput, count, sum, ending);
        }

        /*
        Задача-3.
        Условие:
            Известно, что 1 дюйм равен 2.54 см. Разработать приложение, переводящие дюймы в сантиметры и наоборот. 
            Диалог с пользователем реализовать через систему меню.
        */
        static void ConverterInchAndCentimetre()
        {
            const float CM_IN_INCH = 2.54f;
            float inch, centimetre;
            Console.WriteLine("Конвертер, переводящий дюймы в сантиметры и наоборот");
            Console.WriteLine("Введите номер пункта и нажмите Enter:");
            Console.WriteLine("1. Перевести дюймы в сантиметры;\r\n" +
                              "2. Перевести сантиметры в дюймы;");
            int numberItem = Convert.ToInt32(Console.ReadLine());
            switch (numberItem)
            {
                case 1:
                    Console.Write("Дюйм: ");
                    inch = Convert.ToSingle(Console.ReadLine());
                    centimetre = CM_IN_INCH * inch;
                    Console.Write("Сантиметры: " + centimetre);
                    break;
                case 2:
                    Console.Write("Сантиметр: ");
                    centimetre = Convert.ToSingle(Console.ReadLine());
                    inch = centimetre / CM_IN_INCH;
                    Console.Write("Дюймы: " + inch);
                    break;
                default:
                    Console.WriteLine("Вы выбрали несуществующий пункт. Программа завершена");
                    break;
            }
        }

        /*
        Задача-4.
        Условие:
            Разработать программу, которая выводит на экран линию из символов. 
            Число символов, какой использовать символ, и какая будет линия - вертикальная, или горизонтальная - указывает пользователь. 
        */
        static void Line()
        {
            Console.WriteLine("Программа выводит на экран линию из символов.");
            Console.Write("Введите символ для отрисовки линии: ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите число символов {0} в линии: ", sign);
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Для выбора направления линии введите номер пункта:");
            Console.WriteLine("1. Горизонтальная линия;\t 2. Вертикальная линия");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; i < number; i++)
                        Console.Write(sign);
                    break;
                case "2":
                    for (int i = 0; i < number; i++)
                        Console.WriteLine(sign);
                    break;
                default:
                    Console.WriteLine("Выбран несуществующий пункт. Программа завершена!");
                    break;
            }
        }

        /*
        Задача-5.
        Условие:
            Написать программу, которая находит сумму всех целых нечетных чисел в диапазоне, указанном пользователе.
        */
        static void SumOddNumbers()
        {
            Console.WriteLine("Программа находит сумму всех целых нечетных чисел в диапазоне, указанном пользователем");
            Console.Write("Введите нижнюю границу диапазона: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите верхнюю границу диапазона: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (!(lowerLimit == upperLimit && lowerLimit % 2 == 0))
            {
                int number = lowerLimit;
                if (number % 2 == 0)
                    number++;
                while (number <= upperLimit)
                {
                    sum += number;
                    number += 2;
                }
                Console.WriteLine("Сумма нечетных чисел в диапазоне от {0} до {1} равна {2} ", lowerLimit, upperLimit, sum);
            }
            else
                Console.WriteLine("В заданом диапазоне нет нечетных чисел. Программа завершена.");
            Console.ReadLine();
        }

        /*
        Задача-6.
        Условие:
            Дано натуральное число n. Написать программу, которая вычисляет факториал неотрицательных целых чисел n.
        */
        static void Factorial()
        {
            Console.WriteLine("Программа вычисляет факториал натуральных целых чисел n");
            Console.WriteLine("Введите целое число больше 0");
            int number = Convert.ToInt32(Console.ReadLine());
            int f = RekursFactorial(number);
            Console.WriteLine("{0}! = {1}",number,f);
            Console.ReadLine();
        }

        /// <summary>
        /// Вычисляет факториал числа. Метод относится к задаче-6
        /// </summary>
        /// <param name="i">Число, факториал которого необходимо вычислить</param>
        /// <returns>Факториал числа</returns>
        static int RekursFactorial(int i)
        {
            if (i == 1)
                return 1;
            i *= RekursFactorial(i - 1);
            return i;
        }

        /*
        Условие:
            Программа для вывода заполненного квадрата
        */
        static void SquareFill()
        {
            Console.WriteLine("Программа для вывода заполненного квадрата 10х10");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

        /*
        Условие:
            Программа для вывода пустого квадрата 10х10
        */
        static void SquareEmpty()
        {
            Console.WriteLine("Программа для вывода пустого квадрата 10х10");
            Console.WriteLine();
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == length-1||j==0||j==length-1)
                        Console.Write("* ");
                    if (i >= 1 && i <= length-2 && j >= 1 && j <= length-2)
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

        /*
        Условие:
            Программа для вывода заполненного треукольника 10х10x10
        */
        static void TriangleFill()
        {
            Console.WriteLine("Программа для вывода заполненного треукольника 10х10x10");
            Console.WriteLine();
            int length = 10;
            for (int i = 1; i < length+1; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

        /*
        Задача-.
            Программа для вывода пустого треукольника 10х10x10
        */
        static void TriangleEmpty()
        {
            Console.WriteLine("Программа для вывода пустого треукольника 10х10x10");
            Console.WriteLine();
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                for (int j = length - i; j > 0; j--)
                {
                    if(i==0||i==length-1||j==length-i||j==1)
                        Console.Write("* ");
                    if (i > 0 && i < length - 1 && j > 1 && j < length - i)
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

        /*
        Условие:
            Программа для вывода заполненного ромба 5х5x5х5
        */
        static void RhombFill()
        {
            Console.WriteLine("Программа для вывода заполненного ромба 5х5x5х5");
            Console.WriteLine();
            int length = 5;
            for (int i = 0; i < 2*length-1; i++)
            {
                for (int j = 0; j<2*length-1-Math.Abs(length-i-1); j++)
                {
                    if (j >= Math.Abs(length - 1 - i))
                        Console.Write("* ");
                    if (j < Math.Abs(length - 1 - i))
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

        /*
        Условие:
            Программа для вывода пустого ромба 5х5x5х5
        */
        static void RhombEmpty()
        {
            Console.WriteLine("Программа для вывода пустого ромба 5х5x5х5");
            Console.WriteLine();
            int length = 5;
            for (int i = 0; i < 2 * length-1; i++)
            {
                if (i < length)
                    for (int j = 0; j < length+i; j++)
                        if (j == length-i-1||j==length+i-1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                else
                    for (int j = 0; j < 3*length-i-2; j++)
                        if (j == i - length + 1 || j == 3 * length - i-3)
                            Console.Write("* ");
                        else
                            Console.Write("  ");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }
    }
}
