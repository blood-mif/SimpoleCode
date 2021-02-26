using System;

namespace Двухмерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[3, 5];

            int[,] myArray1 = new int[3, 5]
{
                { 2,43,543,65,23},
                {32,43,54,65,25},
                {34,21,654,76,21}
};


            int[,] myArray2 = new int[,]
            {
                { 2,43,543,65,23},
                {32,43,54,65,25},
                {34,21,654,76,21}
            };

            int[,] myArray3 = 
            {
                { 2,43,543,65,23},
                {32,43,54,65,25},
                {34,21,654,76,21}
            };

            myArray[1, 3] = 65;



            //вывод

            foreach (var item in myArray3)
            {
                Console.Write(item + " ");
            }

            //.Rank позволяет узнать мерность массива
            Console.WriteLine(myArray3.Rank);
            //.Length позволяет узнать количество ВСЕХ элементов
            Console.WriteLine(myArray3.Length);
            //метод .GetLenght() позволяет узнать количество элементов в измерение
            // в данном случае тут говорится сколько элементов в данном двухмерном массиве по вертикали = 3
            Console.WriteLine(myArray3.GetLength(0));
            // в данном случае тут говорится сколько элементов в данном двухмерном массиве по горизонтали = 5
            Console.WriteLine(myArray3.GetLength(1));
            
            //int hight = myArray3.GetLength(0);
            //int width = myArray3.GetLength(1);

            for (int y = 0; y < myArray3.GetLength(0); y++)
            {
                for (int x = 0; x < myArray3.GetLength(1); x++)
                {
                    Console.Write(myArray3[y,x] + "\t");
                }
                Console.WriteLine();
            }




        }
    }
}
