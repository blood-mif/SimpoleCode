using System;
using System.Linq;

namespace Массивы_2___как_работать
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 324, 5435, 232, 45, 535, 66, 23, 11, 21 , 21 , 11, 324};
            //минимальный .Min и максимальный .Max элемент массива в 1 строчку
            int resultMax = myArray.Max();
            int resuliMin = myArray.Min();
            Console.WriteLine(resuliMin + " и " + resultMax);
            // сумма всех элементов в массиве .Sum
            Console.WriteLine(myArray.Sum());
            // сумма всех чётных элементов в массиве .Where(i=> i % 2 == 0).Sum
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            // самое маленькое не чётное число массива
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());
            // найти уникальные элементы массива и поместить их в новый массив
            int[] result = myArray.Distinct().ToArray();
            // отсортировать элементы по возрастанию из старого массива в новый
            int[] result1 = myArray.OrderBy(i => i).ToArray();
            // отсортировать элементы по убыванию из старого массива в новый
            int[] result2 = myArray.OrderByDescending(i => i).ToArray();

            //Найти все элементы <70 и записать их в новый массив
            int[] result6 = myArray.Where(i => i < 70).ToArray();
            //Найти первый элемент <70 и записать его в интовую переменную
            int result7 = myArray.Where(i => i < 70).First();
            //Найти первый элемент <70 и записать его в интовую переменную, если нет подходящих элементов метод возвращает дефолтное значение
            int result8 = myArray.Where(i => i < 0).FirstOrDefault();

            // Сортировка через класс Array. в старом массиве без нового
            Array.Sort(myArray);
            // Метод .Find для поиска элемента (в данном случае <70) с начала в конец массива
            Array.Find(myArray, i => i < 70);
            // Метод .FindLast для поиска элемента (в данном случае <70) с конеца в начала массива
            Array.FindLast(myArray, i => i < 70);
            // Метод .FindAll для поиска всех элементов (в данном случае <70) - результатом работы должен быть массив
            int[] result3 = Array.FindAll(myArray, i => i < 70);
            // Метод .FindIndex для поиска индекса по элементу,(Если несколько одинаковых элементов берёт первый) результат интовая переменная, перебор элементов сначала в конец
            int result4 = Array.FindIndex(myArray, i => i == 535);
            // Метод .FindLastIndex для поиска индекса по элементу,(Если несколько одинаковых элементов берёт первый) результат интовая переменная, перебор элементов с конца в начало
            int result5 = Array.FindLastIndex(myArray, i => i == 535);
            // пересобирает массив сделав элементы в обратном порядке
            Array.Reverse(myArray);


        }
    }
}
