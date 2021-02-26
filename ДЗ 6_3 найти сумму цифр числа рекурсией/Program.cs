using System;

namespace ДЗ_6_3_найти_сумму_цифр_числа_рекурсией
{
    class Program
    {

        static int sum(int value)
        {

            if (value < 10)
            {
                return value;
            }
            int lastElementValue = value % 10;
            int nextValue = value / 10;

            return lastElementValue + sum(nextValue);
        }

        static int sum2(int value)
        {
            if (value<10)
            {
                return value;
            }
            return value % 10 + sum2(value / 10);
        }

        static int sum3(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result += value % 10; // result = result + value % 10;
                value = value / 10; // value /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            
            int value = 561;
            int result = sum(value);
            Console.WriteLine(result);

            result = sum2(value);
            Console.WriteLine(result);

            result = sum3(value);
            Console.WriteLine(result);

        }
    }
}
