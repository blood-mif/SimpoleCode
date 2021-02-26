using System;

namespace ДЗ_4_1_метод_вывода_строки__символы_и_количество_вводятся_пользователем
{
    class Program
    {
        static void PrintLine(string symbol, int numberSymbol)
        {

            for (int i = 0; i <= numberSymbol; i++)
            {
                Console.Write(symbol);
            }
        }

        static void Sum()
        {
        Console.WriteLine("Введите число 1 ");
        int value_1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2 ");
            int value_2 = int.Parse(Console.ReadLine());
            int result = value_1 + value_2;
            Console.WriteLine("Сумма = " + result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ для строки");
            string symbol = Console.ReadLine();
            Console.WriteLine("Введите количетво символов в строке");
            int numberSymbol = int.Parse(Console.ReadLine());
            PrintLine(symbol,numberSymbol);
            Console.ReadKey();
        }
    }
}
