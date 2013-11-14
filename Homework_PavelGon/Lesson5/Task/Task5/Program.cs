using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
   public class Program
    {
        public static int Main()
        {
            try
            {
                Russia.City.Moscow moscow = new Russia.City.Moscow();
                Bellarus.City.Minsk minsk = new Bellarus.City.Minsk();
                Ukraine.City.Kiev kiev = new Ukraine.City.Kiev();
                Console.WriteLine("Население городов столиц");
                Console.WriteLine("Город: {0}; Население: {1} человек",minsk.name, minsk.population);
                Console.WriteLine("Город: {0}; Население: {1} человек", kiev.name, kiev.population);
                Console.WriteLine("Город: {0}; Население: {1} человек", moscow.name, moscow.population);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}

namespace Russia
{
    namespace City
    {
        class Moscow
        {
            internal string name = "Москва";
            internal int population = 11979529;
        }
    }
}

namespace Bellarus
{
    namespace City
    {
        class Minsk
        {
            internal string name = "Минск";
            internal int population = 1912200;
        }
    }
}

namespace Ukraine
{
    namespace City
    {
        class Kiev
        {
            internal string name = "Киев";
            internal int population = 2843990;
        }
    }
}
