using System;

namespace Зубчатый___ступенчатый___массив
{
    class Program
    {
        static void Main(string[] args)
        {
            //каждая строка может содержать разное количество элементов,массив массивов
            //[][] для обозначчения массива массивов

            /*
            int[][] myArray = new int [3][];
            int[,] myArray2 = new int[3, 5];

            int myArrayRank = myArray.Rank;
            int myArray2Rank = myArray2.Rank;

            Console.WriteLine(myArrayRank);
            Console.WriteLine(myArray2Rank);

            int myArrayLenght = myArray.Length;
            int myArray2Lenght = myArray2.Length;

            Console.WriteLine(myArrayLenght);
            Console.WriteLine(myArray2Lenght);

            */

            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[12];
            myArray[0][2] = 37;
            //обращение к 1ой сткоре 3тий элемент

            Console.WriteLine(myArray[0][2]);
            // вытаскиваем первую строку(массив из массивов) в новый массив
            int[] arr = myArray[0];

            //заполним случайным значениея 

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "  ");
                }
                Console.WriteLine();
            }


        }
    }
}
