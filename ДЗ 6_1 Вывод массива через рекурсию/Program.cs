using System;

namespace ДЗ_6_1_Вывод_массива_через_рекурсию
{
    class Program
    {
        static void getElementArray(int[] array, int i = 0)
        {
            
            
            if (i < array.Length)
            {
            Console.WriteLine(array[i]);
            getElementArray(array,i+1);
            }

        }
        static void Main(string[] args)
        {
            int[] array = { 3, 46, 43, 32, 654, 76, 12, 54, 21, 66 };
            getElementArray(array);

        }
    }
}
