using System;

namespace Циклы_For
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Если а перед выводом");
            for (int a = 0; a < 3; )
            {
                a++;
                Console.WriteLine(a);
            }
            Console.WriteLine("Если а после вывода");
            for (int a = 0; a < 3;)
            {
                
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("идём дальше");
            int b = 0;
            for (; b < 3; b++)
            {
                Console.WriteLine("For first cucl " +b);
            }
            for (; b < 5; b++)
            {
                Console.WriteLine("For second cucl " + b);
            }
            Console.WriteLine("обьявление нескольних переменных ,условий, инкрементов");
            for (int i = 0,j=5; i < 3 && j < 10; i++,j++)
            {
                Console.WriteLine("i = " + i);
                Console.WriteLine("j = " + j);
            }

            Console.WriteLine("Цикл в обратном порядке");

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Задано в консоли");
            for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
