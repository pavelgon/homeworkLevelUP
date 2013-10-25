using System;
using System.Text;

namespace SquareInRectangle
{
    class Program
    {
        static void Main()
        {
            uint sideRectangle_1, sideRectangle_2, sideSquare;
            ulong areaSquare, areaRectangle, freeArea;
            int countSquareInRectangle;

            Console.WriteLine("Введите длину первой стороны прямоугольника");
            sideRectangle_1 = InputSideFigure();
            
            Console.WriteLine("Введите длину второй стороны прямоугольника");
            sideRectangle_2 = InputSideFigure();
            
            Console.WriteLine("Введите длину стороны квадрата");
            sideSquare = InputSideFigure();

            while (sideSquare > sideRectangle_1 || sideSquare > sideRectangle_2)
            {
                Console.WriteLine("В прямоугольник нельзя разместить ни одного квадрата " +
                                    "со стороной {0}, измените значение стороны квадрата", sideSquare);
                Console.WriteLine("Введите длину стороны квадрата");
                sideSquare = InputSideFigure();
            }
            
            Console.WriteLine("Вы ввели следующие значения\r\n"+
                                "Прямоугольник со сторонами {0}x{1}\r\n"+
                                "Квадрат со сторонами {2}", sideRectangle_1, sideRectangle_2, sideSquare);

            areaRectangle = AreaRectangleAndSquare(sideRectangle_1, sideRectangle_2);
            areaSquare = AreaRectangleAndSquare(sideSquare, sideSquare);
            countSquareInRectangle = CountSquareInRectangle(sideRectangle_1, sideRectangle_2, sideSquare);
            freeArea = areaRectangle - ((ulong)countSquareInRectangle * areaSquare);
            Console.WriteLine();
            Console.WriteLine("Количество квадратов размещенных в прямоугольнике: {0}", countSquareInRectangle);
            Console.WriteLine("Свободная площадь: {0}",freeArea);


            Console.ReadLine();
        }
        
        static uint InputSideFigure()
        {
            uint x;
            do
            {
                if (UInt32.TryParse(Console.ReadLine(), out x) && x>0)
                    return x;
                else
                    Console.WriteLine("Некорректный ввод, повторите");
            }while(true);
        }

        static ulong AreaRectangleAndSquare(uint a, uint b)
        {
            return a * b;
        }

        static int CountSquareInRectangle(uint sideRectangle_1, uint sideRectangle_2, uint sideSquare)
        {

            double countSquareSideX = Math.Truncate((double)(sideRectangle_1 / sideSquare));
            double countSquareSideY = Math.Truncate((double)(sideRectangle_2 / sideSquare));
            return (int)(countSquareSideX * countSquareSideY);
        }
    }
}
