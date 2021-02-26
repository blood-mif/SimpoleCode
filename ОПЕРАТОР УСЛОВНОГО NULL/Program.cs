using System;
using System.Linq;

namespace ОПЕРАТОР_УСЛОВНОГО_NULL
{
    class Program
    {
      //  static 
        
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }
        static void Main(string[] args)
        {
            //ОПЕРАТОР УСЛОВНОГО NULL ?.

            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементоа массива " + myArray?.Sum()); // если в массиве null то код после ?. выполнятся не будет
            myArray = null;
            Console.WriteLine("Сумма элементоа массива " + (myArray?.Sum() ?? 0)); // при null установить дефолтное значение 0
        }
    }
}
