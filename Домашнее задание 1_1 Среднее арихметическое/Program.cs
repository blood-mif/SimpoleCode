using System;

namespace Домашнее_задание_1_1_Среднее_арихметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            double first = Convert.ToDouble(str);
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            double second = Convert.ToDouble(str);
            Console.WriteLine("Среднее арифметическое двух чисел = " + (first + second) / 2);
        }
    }
}
