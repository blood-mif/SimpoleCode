using System;
using System.Linq;

namespace Одномерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArroy;
            myArroy = new int[5];

            //Можно обьявить массив так    int[] myArroy = new int[5];
            myArroy[0] = 17;
            myArroy[1] = 3;
            myArroy[2] = 9;
            myArroy[4] = 13;
            //  или так, но количество элементов должно совпадать  int[] myArroy = new int[5] {17,3,9,0,13};
            // а так не должно =), тут не указываешь количество элементов массива int[] myArroy = new int[] {17,3,9}; 
            // можно не повторять тип элеменитов int[] myArroy = new [] {17,3,9};
            // или даже так int[] myArroy = {17,3,9};

        
            

            int a = myArroy[0];
            Console.WriteLine(myArroy[0]+myArroy[1]);
            Console.WriteLine(a);
            Console.WriteLine(".Length выводит количество элементов в массиве");
            Console.WriteLine(myArroy.Length);
            Console.ReadKey();

            // изменить дефолтное значение элемента в массиве
            int[] myArroy2 = Enumerable.Repeat(5, 10).ToArray();
            // another metod , будет 5 элементов а начинаться значения в массе будут с 4 
            int[] myArroy3 = Enumerable.Range(4, 5).ToArray();

        }
    }
}
