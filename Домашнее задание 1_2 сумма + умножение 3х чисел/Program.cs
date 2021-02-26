using System;

namespace Домашнее_задание_1_2_сумма___умножение_3х_чисел
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
            Console.WriteLine("Введите третье число число");
            str = Console.ReadLine();
            double second2 = Convert.ToDouble(str);
            Console.WriteLine("Сумма чисел = " + first + second + second2);
            Console.WriteLine("Произведение чисел = " + first * second * second2);
            Console.WriteLine("Сумма и произведение чисел = " + (first + second + second2) + first * second * second2);

        }
    }
}
