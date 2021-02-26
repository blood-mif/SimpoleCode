using System;

namespace Ключевое_слово_params
{
    class Program
    {

        static int sum(params int[] parameters)
        { 
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];   
            }
            return result;
        }

        static void Foo(params object[] parameters)
        {
            string message = "Тип данный {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message,item.GetType(),item);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 23, 76, 44, 5 };
            Console.WriteLine(sum(array));
            Console.WriteLine();
            Console.WriteLine();

            Foo("test", 5, 'g', 5.666f, false);
        }
    }
}
