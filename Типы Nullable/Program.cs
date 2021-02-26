using System;

namespace Типы_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;


            DateTime? dateTime = null;

            /*
            a.HasValue -булевая переменная, проверка на наличие null.
            Если a = null возвращает false,
            если a = 1(число) - возвращает true
            
             a.Value - реальные данные в переменное
            Если a = null - То ничего не вернёт, будет ошибка
            если a = 1(число) - возвращает реальные данные
             */

            // выясняем что в перенной "a"
            int? a = null;

            Console.WriteLine(a == null) ; //true

            Console.WriteLine(a.HasValue); // false

            Console.WriteLine(a.GetValueOrDefault()); // 0

            Console.WriteLine(a.GetValueOrDefault(5)); // тут мы меняем дефолтное значения с 0 на 5

            Console.WriteLine(a ?? 55); // ?? - значит, если у нас в значение null - верни 55

            Console.WriteLine(a.Value); //InvalidOperationException: "Nullable object must have a value."

        }
    }
}
