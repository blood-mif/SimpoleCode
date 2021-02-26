using System;

namespace Трёхмерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray0 = new int[4, 3, 5];

            myArray0[1, 2, 3] = 55;
          //  Console.WriteLine(myArray0[1,2,3]);

            int[,] myArray1 =
            {

                    {1,32,43,5 },
                    {34,5436,321,56 },
                    {324,43,32,65 },
            };
            

            int[,,] myArray2 =
            {
                {
                    {1,32,43,5 },
                    {32,54,76,87 }
                },
                {
                    {34,5436,321,56 },
                    {32,54,76,87 }
                },
                {
                    {324,43,32,65 },
                    {32,54,87,09 }
                }
            };

            Random random = new Random();
            //прямоугольный массив
            Console.WriteLine("Прямоугольный трёхмерный массив");
            int[,,] myArray3 = new int[3, 4, 5];

            for (int i = 0; i < myArray3.GetLength(0); i++)
            {
                for (int j = 0; j < myArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray3.GetLength(2); k++)
                    {
                        myArray3[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray3.GetLength(0); i++)
            {
                for (int j = 0; j < myArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray3.GetLength(2); k++)
                    {
                        Console.Write(myArray3[i, j, k] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //зубчатый массив
            Console.WriteLine("Зубчатый трёхмерный массив");
            int[][][] myArray4 = new int[random.Next(3, 6)][][];
            for (int i = 0; i < myArray4.Length; i++)
            {
                myArray4[i] = new int[random.Next(2,6)][];
                for (int j = 0; j < myArray4[i].Length; j++)
                {
                    myArray4[i][j] = new int[random.Next(2,6)];
                    for (int k = 0; k < myArray4[i][j].Length; k++)
                    {
                        myArray4[i][j][k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray4.Length; i++)
            {
                
                for (int j = 0; j < myArray4[i].Length; j++)
                {
                    
                    for (int k = 0; k < myArray4[i][j].Length; k++)
                    {
                        Console.Write(myArray4[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
