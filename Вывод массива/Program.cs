﻿using System;

namespace Вывод_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
