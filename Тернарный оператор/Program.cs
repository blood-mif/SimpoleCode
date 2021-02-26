using System;

namespace Тернарный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == storedPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }

            Console.WriteLine(accessAllowed);

            Console.WriteLine("Альтернатива");

            string storedPassword1 = "qwerty";
            string enteredPassword1 = Console.ReadLine();

            // тетрнырный оператор - [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
            accessAllowed = enteredPassword1 == storedPassword1 ? true : false;
            Console.WriteLine(accessAllowed);

            int inputData = int.Parse(Console.ReadLine());
            int outputDate = inputData < 0 ? 0 : inputData;
            Console.WriteLine(outputDate);
            Console.ReadKey();

        }
    }
}
