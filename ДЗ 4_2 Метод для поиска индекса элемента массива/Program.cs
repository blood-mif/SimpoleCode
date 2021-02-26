using System;

namespace ДЗ_4_2_Метод_для_поиска_индекса_элемента_массива
{
    class Program
    {
        static int FoundIndex(int[] arr, int element)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    result = i;
                    //Console.WriteLine("Индекс первого элемента со значением " + element + " = " + result);
                    break;
                }
                if (i == arr.Length - 1)
                {
                    result = -1;
                   // Console.WriteLine("Такого элемента нет в массиве");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = { -32, 432, 12, 55, 43, 65, 44, 55, 9, 7 };
            Console.WriteLine("Введите значение элемента");
            int element = int.Parse(Console.ReadLine());
            
            int result = FoundIndex(arr, element);
            if (result==-1)
            {
                Console.WriteLine("Такого элемента нет в массиве");
            }
            else
            {
                Console.WriteLine("Индекс первого элемента со значением " + element + " = " + result);
                
            }

            Console.ReadKey();
        }
    }
}
