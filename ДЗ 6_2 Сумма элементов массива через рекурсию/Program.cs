using System;

namespace ДЗ_6_2_Сумма_элементов_массива_через_рекурсию
{
    class Program
    {
        static void getElementArray(int[] array, int i, int sum)
        {

            if (i >= array.Length - 1)
            {
                Console.WriteLine(sum);
                return ;
            }
            sum = array[i] + sum;
            i++;

            getElementArray(array, i, sum);
        }
        static void Main(string[] args)
        {
            int i = 0;
            int sum =0;
            int[] array = { 3, 46, 43, 32, 654, 76, 12, 54, 21, 66 };
            getElementArray(array,i,sum);


        }
    }
}
