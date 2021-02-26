using System;

namespace Заполнение_двумерного_массива_с_клавиатуры
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 6];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    myArray[i, j] = random.Next(100);
                }
                
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] myArray1 = new int[2, 3];

            

            for (int i = 0; i < myArray1.GetLength(0); i++)
            {
                for (int j = 0; j < myArray1.GetLength(1); j++)
                {
                    Console.WriteLine("Y: "+ i + " X: " +j);
                    myArray1[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < myArray1.GetLength(0); i++)
            {
                for (int j = 0; j < myArray1.GetLength(1); j++)
                {

                    Console.Write(myArray1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("А теперь стринг массив");
            string[,] myArray2 = new string[2, 3];

            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray2[i, j] = Console.ReadLine();
                }

            }

            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {

                    Console.Write(myArray2[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
