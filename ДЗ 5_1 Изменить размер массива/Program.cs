using System;

namespace ДЗ_5_1_Изменить_размер_массива
{
    class Program
    {
        static void Resize<T> (ref T[] arr)
        {
            
            Console.WriteLine("Введите количество элементов массива ");
            int size = int.Parse(Console.ReadLine());
            T[] newArray = new T[size];

            for (int i = 0; i < arr.Length && i < size; i++)
            {
                newArray[i] = arr[i];
            }

            arr = newArray;
        }



        static void Main(string[] args)
        {
            int[] myArray = { 2,54,43,1,7};
            string[] myArrayString = { "Hello", "My", "World" };
            Resize(ref myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "  ");
            }
            Resize(ref myArrayString);
            for (int i = 0; i < myArrayString.Length; i++)
            {
                Console.Write(myArrayString[i] + "  ");
            }

            Console.ReadKey();
            
        }
    }
}
