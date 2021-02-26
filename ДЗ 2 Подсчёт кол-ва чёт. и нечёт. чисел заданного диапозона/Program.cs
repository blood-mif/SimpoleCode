using System;

namespace ДЗ_2_Подсчёт_кол_ва_чёт._и_нечёт._чисел_заданного_диапозона
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstValue;
            int secondValue;
            
            while (true)
            {
            int even = 0;
            int notEven = 0;
                int summaEven = 0;
                int summaNotEven = 0;

                try
                {
                    Console.WriteLine("Enter first number");
                    firstValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    secondValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Warring! use another format");
                    Console.ReadKey();
                    continue;

                }
                if (secondValue < firstValue)
                {
                    Console.WriteLine("the first number must be greater than the second number");
                    continue;
                }

            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                {
                    Console.WriteLine("EVEN! " + firstValue);
                    even++;
                        
                        summaEven = summaEven + firstValue;
                }
                else
                {
                    Console.WriteLine("NOTEVEN! " + firstValue);
                    notEven++;
                        summaNotEven += firstValue;
                    }
                firstValue++;
            }
            Console.WriteLine("ALL EVEN = " + even);
            Console.WriteLine("ALL NOTEVEN = " + notEven);
                Console.WriteLine("Symma Even = " + summaEven);
                Console.WriteLine("Symma NOTEven = " + summaNotEven);
                Console.ReadKey();
            Console.Clear();
            }
        }
    }
}
