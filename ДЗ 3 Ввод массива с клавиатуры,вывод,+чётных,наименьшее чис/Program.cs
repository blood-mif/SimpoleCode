using System;

namespace ДЗ_3_Ввод_массива_с_клавиатуры_вывод__чётных_наименьшее_чис
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Инициализация массива
             * ввод элементов
             * вывод элементов массива в обратном порядке
             * сумма чётных чисел
             * найти наимешее число в массиве
             */

            Console.Write("Введите количество элементов массива: \t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArroy = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                Console.Write("\nВведите элемент массива с индексом:myArroy["+i+"] =\t");
                myArroy[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < myArroy.Length; i++)
            {
                Console.WriteLine(myArroy[i]);
            }
            Console.WriteLine("\nВывод массива в обратном порядке:");
            for (int i = myArroy.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArroy[i]);
            }

            Console.Write("\nСумма всех чётний элементов массива:\t");
            int symma = 0;
            for (int i = 0; i < myArroy.Length; i++)
            {
                if (myArroy[i] % 2 == 0)
                {
                    symma = symma + myArroy[i];
                }
               
            }
            Console.Write(symma);

            Console.Write("\n Наименьший элемент массива:\t");
            int minElement = 2147483647;
            for (int i = 0; i < myArroy.Length; i++)
            {
                if (myArroy[i] < minElement)
                {
                    minElement =  myArroy[i];
                }

            }
            Console.Write(minElement);

            Console.Write("\n Максимум и мимимум через сравнение только элементов массива:");
            int min = myArroy[0];
            int max = myArroy[0];
            int startPoint = myArroy[0];
            for (int i = 1; i < myArroy.Length; i++)
            {
                if (myArroy[i] < startPoint)
                {
                    startPoint = myArroy[i];
                    min = myArroy[i];
                }
                else if (myArroy[i] > startPoint)
                {
                    startPoint = myArroy[i];
                    max = myArroy[i];
                }

            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.ReadKey();
        }

    }
}
