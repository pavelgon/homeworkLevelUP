using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Program
    {
        public static Int32 Main()
        {
            try
            {
                Itayp itayp = new Itayp();
                TransTrunkRoad transSib = new TransTrunkRoad();
                GoldenGate goldenGate = new GoldenGate();
                Console.WriteLine("Чудеса света:\r\n"+
                    "1. Имя: {0}\r\n"+
                    "   Тип: {1}\r\n"+
                    "   Расположение: {2}\r\n"+
                    "   Сброс воды: {3}\r\n"+
                    "2. Имя: {4}\r\n"+
                    "   Тип: {5}\r\n"+
                    "   Расположение: {6}\r\n"+
                    "   Длина: {7}\r\n"+
                    "3. Имя: {8}\r\n"+
                    "   Тип: {9}\r\n"+
                    "   Расположение: {10}\r\n"+
                    "   Выдерживаемая нагрузка на одну сваю: {11}\r\n",
                    itayp.Name, itayp.Kind, itayp.Location, itayp.WaterEscape,
                    transSib.Name, transSib.Kind, transSib.Location, transSib.Length,
                    goldenGate.Name, goldenGate.Kind, goldenGate.Location, goldenGate.LoadPile
                    );

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
