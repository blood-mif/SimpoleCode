using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string str;
                double firstValue;
                double secondValue;


                Console.WriteLine("Введите первое число: ");
                str = Console.ReadLine();
                bool result1 = double.TryParse(str, out firstValue);
                if (result1)
                {
                }
                else
                {
                    Console.WriteLine("Ошибка ввода второго числа, используйте только числа");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите второе число: ");
                str = Console.ReadLine();
                bool result2 = double.TryParse(str, out secondValue);
                if (result2)
                {
                }
                else
                {
                    Console.WriteLine("Ошибка ввода второго числа, используйте только числа");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите желаемую операцию: + - * / ");
                str = Console.ReadLine();
                if (str == "+")
                {
                    double res = firstValue + secondValue;
                    Console.WriteLine("Сложение чисел " + firstValue + " и " + secondValue + " = " + res);
                }

                else if (str == "-")
                {
                    double res = firstValue - secondValue;
                    Console.WriteLine("Вычитание чисел " + firstValue + " и " + secondValue + " = " + res);
                }


                else if (str == "*")
                {
                    double res = firstValue * secondValue;
                    Console.WriteLine("Умножение чисел " + firstValue + " и " + secondValue + " = " + res);
                }

                else if (str == "/")
                {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!!!");
                        Console.ReadLine();
                        continue;
                    }
                    double res = firstValue / secondValue;
                    Console.WriteLine("Деление чисел чисел = " + firstValue + " и " + secondValue + " = " + res);
                }
                else
                {
                    Console.WriteLine("Вы ввели не верный символ математической операции");
                }
                Console.ReadKey();
            }

        }
    }
}
