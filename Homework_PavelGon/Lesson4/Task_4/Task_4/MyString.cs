using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    class MyString
    {
        static public void StatisticString(string str)
        {
            int sign = str.Length;
            int countLetter = 0, countLowLetter=0, countUpLetter=0, 
                countDigit=0, countPunctuation=0, countSpace=0;
            
            Console.Write("Общее количество символов: " + sign+"\r\n");

            foreach (char item in str)
            {
                if (char.IsLetter(item))
                {
                    countLetter++;
                    if (char.IsUpper(item))
                        countUpLetter++;
                    else
                        countLowLetter++;
                }
                else if (char.IsDigit(item))
                    countDigit++;
                else if (char.IsPunctuation(item))
                    countPunctuation++;
                else if (char.IsWhiteSpace(item))
                    countSpace++;
            }

            Console.WriteLine(
                "Общее количество букв: {0}\r\n" +
                "Букв нижнего регистра: {1}\r\n" +
                "Букв верхнего регистра: {2}\r\n" +
                "Количество цифр: {3}\r\n" +
                "Количество символов пунктуации: {4}\r\n" +
                "Количество пробельных символов: {5}", countLetter, countLowLetter, countUpLetter,
                                                        countDigit, countPunctuation, countSpace);

        }

        static public void UpSign(ref string str, char ch)
        {
            ch = char.ToLower(ch);
            char[] temp = str.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ch)
                    temp[i]=char.ToUpper(temp[i]);
            }
            str = new string(temp);
        }

        static public void DeletePartString(ref string str, char ch)
        {
            int index = str.LastIndexOf(ch);
            str = str.Remove(index);
        }
    }
}
