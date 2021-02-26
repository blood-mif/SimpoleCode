using System;

namespace Нарисовать_треугольники_только_вложенными_циклами
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Выберите символ для рисования = ");
            string symvol = Console.ReadLine();
            Console.Write("Выберете количество символов для ширины = ");
            int widht = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < widht; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symvol);
                }
            }

            Console.WriteLine(" ");

            for (int k = 0; k < widht; k++)
            {
                
                Console.WriteLine();
                for (int j = widht; j > k; j--)
                {
                    Console.Write(symvol);
                }
            }



            for (int k = 0; k < widht; k++)
            {

                Console.WriteLine();
                for (int j = widht - 1; j > k; j--)
                {
                    Console.Write(" ");
                }
                for (int i = k; i <= k; i++)
                {
                    for (int z = 0; z <= k; z++)
                    {
                        Console.Write(symvol);
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < widht; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = widht; i < z; z--)
                {

                        Console.Write(symvol);
                    
                }

            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
