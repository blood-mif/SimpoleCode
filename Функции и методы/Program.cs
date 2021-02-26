using System;

namespace Функции_и_методы
{

    //Модификаторы тип_возвращаемого_значения название_метода(параметры)
    class Program
    {
        static int Sum(int value_1, int value_2) 
        {
            int result = value_1 + value_2;

            return result;
            //return a + b;
        }

        //void не возвращает значение

        static void PrintLine() //что бы метод не принимал никаких параметров оставляем скобки пустыми
        {
            Console.WriteLine("Метод PrintLine был вызван");
        }
        static void PrintResult(int result)
        {
            Console.WriteLine("Результут сложения = " + result);
        }
        static void Main(string[] args)
        {
            int a, b,c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Sum(a, b);
            PrintResult(c);
            Console.WriteLine("================");
            Console.ReadKey();
            PrintLine();

        }
    }
}
