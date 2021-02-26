using System;

namespace ДЗ_1_3_конвектор_валют_с_корвертаций_через_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Через конвертирование string от readline в double через парс | double.Parse(); |
            double first2;
            Console.WriteLine("Введите число рублей для конвертации в баксы");
            first2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Из " + first2 + " рублей получится " + (first2 / 90) + " долларов");

        }
    }
}
