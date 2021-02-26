using System;

namespace Проверка_на_четность
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double firstValue;

            str = Console.ReadLine();

            bool result = double.TryParse(str, out firstValue);
            if (result)
            {
            }
            else
            {
                Console.WriteLine("Ошибка ввода формата числа, используйте только числа");
                return;
            }
           
            if (firstValue % 2 == 0 )
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Чило не чётное");
            }
        }
    }
}
