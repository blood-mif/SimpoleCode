using System;

namespace Циклы_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number;
            Console.WriteLine("введите количество циклов");
            number = int.Parse(Console.ReadLine());
            while (count < number)
            {
                count++;
                Console.WriteLine("Hello World!");
                
            }
            Console.ReadLine();
        }
    }
}
