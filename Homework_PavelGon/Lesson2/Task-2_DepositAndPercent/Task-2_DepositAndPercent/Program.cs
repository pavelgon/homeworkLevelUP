using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2_DepositAndPercent
{
    class Program
    {
        const double DEPOSIT = 1000;
        const double CHECKSUM_DEPOSIT = 1100;
        static void Main(string[] args)
        {
            double p;
            double currentDeposit = DEPOSIT;
            int countMonthWhereDepositMore;
            Console.WriteLine("Программа для расчета количества времени, которое"+
                                "потребуется для превышения вклада 1100 руб.\r\n"+
                                "Начальные условия:\r\n Начальный депозит составляет 1000 руб;\r\n"
                                + "Процент вклада составляет от 0 до 25 и устанавливается пользователем.\r\n");
            Console.Write("Установите размер процентной ставки от 0 до 25: ");
            p = CheckInputPercent();
            for (countMonthWhereDepositMore = 0; 
                                        currentDeposit<=CHECKSUM_DEPOSIT; 
                                        countMonthWhereDepositMore++)
            {
                currentDeposit *= (1 + p / 100);
            }
            Console.WriteLine("через {0} месяцев вклад {1} при процентной"
                                +"ставки {2:00.00}% составит {3:0000.00}", countMonthWhereDepositMore
                                , DEPOSIT,p, currentDeposit);
            Console.ReadLine();


        }

        static double CheckInputPercent()
        {
            double p = 0;
            bool check = false;
            do
	        {
	            string percent = Console.ReadLine();
                if (Double.TryParse(percent, out p) && p >= 0 && p <= 25)
                    check = true;
                else
                {
                    Console.WriteLine();
                    Console.Write("Некорректный ввод. Повторите еще раз: ");
                    check = false;
                }
	        } while (!check);
            return p;
        }
    }
}
