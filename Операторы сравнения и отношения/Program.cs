using System;

namespace Операторы_сравнения_и_отношения
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ==  равно
             !=  не равно
             <   меньше
             >   больше
             <=  меньше или равно
             >=  больше или равно
             
             */

            int a = 5;
            int b = 4;

            bool result = a == b;
            Console.WriteLine(result);
            Console.WriteLine(a != b);
        }
    }
}
