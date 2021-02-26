using System;

namespace Конвертация_данных__полученных_через_консоль_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // материал урока из
            // https://www.youtube.com/watch?v=rMEzXVgxQ7o&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=8
            string str;
            Console.WriteLine("Введите первое число для провеки конвертации через Convert.ToDouble");
            str = Console.ReadLine();
            double second = Convert.ToDouble(str);
            Console.WriteLine("Для проверки успешной конвертации в double поделим число " + second + " на 0.3, получится  " + second / 0.3);

            //Через конвертирование string от readline в double через парс | double.Parse(); |
            double first;
            Console.WriteLine("Введите число для проверки конвертации через double.Parse()");
            //Число при введение через консоль имеет тип String
            first = double.Parse(Console.ReadLine());
            Console.WriteLine("Для проверки успешной конвертации в double поделим число " + first + " на 0.3, получится  " + first / 0.3 );

            // Проверка возможности конвертации через true catch, более накладно по ресурсам 
            double secondValue;
            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();
            try
            {
                double firstValue = Convert.ToDouble(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода первого числа, используйте только числа");
            }


            // Проверка через TryParse возвращает булевый ответ, мнимая конструкция кушает меньше ресурсов
            Console.WriteLine("Введите второе число: ");
            str = Console.ReadLine();
            bool result = double.TryParse(str, out secondValue);
            if (result)
            {
            }
            else
            {
                Console.WriteLine("Ошибка ввода второго числа, используйте только числа");
                return;
            }

        }
    }
}
