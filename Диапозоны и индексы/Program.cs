using System;

namespace Диапозоны_и_индексы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 423, 654, 32, 65, 76, 98, 2 };


            Console.WriteLine(myArray[myArray.Length -1]);
            Console.WriteLine(myArray[^1]);
            // ^ этот символ говорит что мы хотим получить элемент с конца, номерация с конца начинается с 1, а не с 0 !
            //диапозон 1 это начало .. это диапозон 5 это конец 
            int[] myArray2 = myArray[1..5];
            // там извлекаются значения с самого первого элемента
            int[] myArray3 = myArray[..5];
            // так  с 3тьего до конца
            int[] myArray4 = myArray[3..];
            //Создание индекса вручную

            Index myIndex = ^2;
            Console.WriteLine(myArray[myIndex]);

            Range myRange = 1..5;
            Range myRange1 = ^1..^4;

            string str = "Hello world !!! =)";
            Console.WriteLine(str[2..^5]);
        }
        
    }
}
