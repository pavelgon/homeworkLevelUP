using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag=false;
            int[] mas;
            int[] temp;
            do
            {
                Console.WriteLine("Занятие-4. Домашнее задание.");
                Console.WriteLine(
                                  "1. Сжать  массив,  удалив  из него все 0 и  заполнить освободившиеся  справа элементы значениями-1\r\n\r\n" +
                                  "2. Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)\r\n\r\n" +
                                  "3. Написать программу, которая предлагает пользователю ввести число и считает сколько раз это число встречается в массиве. Массив заполняется случайными числами в диапазоне от -30 до 30.\r\n\r\n" +
                                  "4. В двумерном массиве порядка M на N поменяйте местами заданные столбцы\r\n\r\n" +
                                  "5. Создать метод принимающий, введенную пользователем, строку и выводящий на экран статистику по этой строке. Статистика должна включать общее количество символов, количество букв (и сколько в верхнем регистре и нижнем), количество цифр, количество символов пунктуации и количество пробельных символов.\r\n\r\n" +
                                  "6. В строке найти все вхождения этого символа и перевести его верхний регистр, а также удалить часть строки, начиная с последнего вхождения этого символа и до конца\r\n\r\n" +
                                  "7. Выход\r\n\r\n");
                Console.Write("Введите пункт меню: ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Сжать  массив,  удалив  из него все 0 и  заполнить освободившиеся  справа элементы значениями-1");
                        mas = new int[] { 1, 0, 45, -2, 0, 5, 6 };
                        temp = (int[])mas.Clone();
                        MyArray.PrintArray(mas);
                        MyArray.Del_0(temp);
                        MyArray.PrintArray(temp);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)");
                        mas = MyArray.CreateArray(10, -9, 10);
                        MyArray.PrintArray(mas);
                        temp = (int[])mas.Clone();
                        temp = MyArray.OtrThenPol(mas);
                        MyArray.PrintArray(temp);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Написать программу, которая предлагает пользователю ввести число и считает сколько раз это число встречается в массиве. Массив заполняется случайными числами в диапазоне от -30 до 30.");
                        Console.WriteLine("Введите длину массива");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число поиска");
                        int number = Convert.ToInt32(Console.ReadLine());
                        mas = MyArray.CreateArray(length, -30, 31);
                        MyArray.PrintArray(mas);
                        int count = MyArray.RepeatItemInArray(mas, number);
                        Console.WriteLine("Количество повторений: {0}", count);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("В двумерном массиве порядка M на N поменяйте местами заданные столбцы: ");
                        Console.Write("Введите количество строк: ");
                        int row = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите количество столбцов");
                        int column = Convert.ToInt32(Console.ReadLine());
                        int[,] masTwoDim = MyArray.CreateTwoDimenArray(row, column);
                        MyArray.PrintArray(masTwoDim);
                        Console.WriteLine("Введите номер первого столбца: ");
                        int column_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите номер второго столбца: ");
                        int column_2 = Convert.ToInt32(Console.ReadLine());
                        MyArray.SwapColumn(masTwoDim, column_1, column_2);
                        Console.WriteLine();
                        Console.WriteLine();
                        MyArray.PrintArray(masTwoDim);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Создать метод принимающий, введенную пользователем, строку и выводящий на экран статистику по этой строке. Статистика должна включать общее количество символов, количество букв (и сколько в верхнем регистре и нижнем), количество цифр, количество символов пунктуации и количество пробельных символов.");
                        Console.WriteLine();
                        Console.WriteLine("Введите строку для анализа");
                        Console.WriteLine();
                        string str = Console.ReadLine();
                        MyString.StatisticString(str);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("В строке найти все вхождения этого символа и перевести его верхний регистр, а также удалить часть строки, начиная с последнего вхождения этого символа и до конца");
                        Console.WriteLine("Введите строку");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Введите символ");
                        char ch = char.Parse(Console.ReadLine());
                        MyString.UpSign(ref str1, ch);
                        Console.WriteLine(str1);
                        ch = char.ToUpper(ch);
                        MyString.DeletePartString(ref str1, ch);
                        Console.WriteLine(str1);
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
