using System;

namespace Преобразование_и_приведение_типов
{
    class Program
    {
        static void Foo(float value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 257;
            double b = 5.4;
            Foo(a);
            Foo((float)b);

            // проверка на арихметическое переполнение
            //byte c = checked((byte)a);
            //Или так
            /*
             * checked
             * {
             * byte c = (byte)a;
             * }
             *  
            */

            //unchecked {  } - соответственно отключение проверки

            try
            {
                byte c = checked((byte)a);
                Console.WriteLine(c);
            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка переполнения! ");
            }

            
            
            bool d = Convert.ToBoolean(a);
            Console.WriteLine("При конвертации в bool, если у нас число != 0, переменная будет = " + d);
            a = 0;
            d = Convert.ToBoolean(a);
            Console.WriteLine("А если у нас число = 0, переменная будет = " + d);

            

        }
    }
}
