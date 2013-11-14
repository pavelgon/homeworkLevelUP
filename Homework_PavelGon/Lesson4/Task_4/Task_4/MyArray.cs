using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    class MyArray
    {
        static Random r = new Random();
        static public void Del_0(int[] mas)
        {

            int index;
            do
            {
                index = Array.IndexOf(mas, 0);
                if (index != -1)
                {
                    for (int i = index; i < mas.Length; i++)
                    {
                        if (i == mas.Length - 1)
                            mas[i] = -1;
                        else
                            mas[i] = mas[i + 1];
                    }
                }
            } while (index != -1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"></param>
        /// <returns>null - Все элементы массива одного знака;</returns>
        static public int[] OtrThenPol(int[] mas)
        {
            bool pol = mas.Any<int>(m => m >=0);
            bool otr = mas.Any<int>(m => m < 0);
            if (pol && otr)
            {
                int[] temp = new int[mas.Length];
                int index = 0;
                foreach (var item in mas)
                {
                    if (item < 0)
                    {
                        temp[index] = item;
                        index++;
                    }
                }
                foreach (var item in mas)
                {
                    if (item >= 0)
                    {
                        temp[index] = item;
                        index++;
                    }
                }
                return temp;
            }
            else
                return mas;
            
        }

        static public int RepeatItemInArray(int[] mas, int item)
        {
            int count = 0;
            foreach (int element in mas)
            {
                if (element == item)
                    count++;
            }
            return count;
        }

        static public void PrintArray(int[] mas)
        {
            foreach (var item in mas)
                Console.Write(item + "  ");
            Console.WriteLine();
        }

        static public void PrintArray(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write(mas[i, j]+"\t");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <returns></returns>
        static public int[] CreateArray(int length, int minValue, int maxValue)
        {
            //Random r = new Random();
            int[] mas = new int[length];
            for (int i = 0; i < length; i++)
                mas[i] = r.Next(minValue, maxValue);
            return mas;
        }

        static public int[,] CreateTwoDimenArray(int row, int column)
        {
            int[,] mas = new int[row, column];
            int[] temp;
            for (int i = 0; i < row; i++)
            {
                temp = CreateArray(column, 1, 10);
                for (int j = 0; j < column; j++)
                    mas[i, j] = temp[j];
            }
            return mas;
        }

        static public void SwapColumn(int[,] mas, int col_1, int col_2)
        {
            int temp;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                temp = mas[i, col_1];
                mas[i, col_1] = mas[i, col_2];
                mas[i, col_2] = temp;
            }
        }
    }
}
