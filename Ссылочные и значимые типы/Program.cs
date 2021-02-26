using System;

namespace Ссылочные_и_значимые_типы
{
    /*
     *      Ссылочные (refrense types) и значимые (value types) типы 
     * 
     *      Стек (stack) и куча (heap)
     */

    
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = new int[11];
            return myArray;
        }

        static void Main(string[] args)
        {
            string str = null;
            string result = str ?? "No data";
            Console.WriteLine(result);
            str = "Have date in str";
            result = str ?? "No data";
            Console.WriteLine(result +" количество знаков в строке = "+ result.Length);
          
            // если использовать ??= то заданное дефолтное значение добавится в result и в str, так можно избавится от лишней переменной
            string strstr = null;
            strstr ??= "Default string";
            // если в переменной находится null в неё присваивается какое либо значение
            str ??= string.Empty; // тут присваивается значение пустой строки
            Console.WriteLine(strstr);
            
           
            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("количество элементов в массиве " + myArray.Length);
            Console.ReadKey();
        }
    }
}
