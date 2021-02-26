using System;

namespace Вложенные_циклы
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация № =" + i);
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine("\t \"Цикл 2 итерация № =" +j);
                }
            }
            */

            //Нарисовать прямоугольник
            Console.Write("Введите высоту прямоугольника ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {

                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
