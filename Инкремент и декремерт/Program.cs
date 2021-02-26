using System;

namespace Инкремент_и_декремерт
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            //постфиксная запись
            a++; //инкремент
            Console.WriteLine(a);
            a--; //декримент
            Console.WriteLine(a);
            //префиксная запись
            ++a;
            Console.WriteLine(a);
            --a;
            Console.WriteLine(a);

            // разница между способами инкремента\декримента в преоритете операции
            Console.WriteLine("Постфиксный инкремент имеет наимеший преоритет, ТЕ сначала выводит значение, потом увеличивает");
            int b = 0;
            Console.WriteLine(b++);
            Console.WriteLine("В предфиксном методе наоборот, сначала увеличение, потом вывод значения");
            int c = 0;
            Console.WriteLine(++c);

            // преоритет префиксного инкремента над умножением
            Console.WriteLine("преоритет префиксного инкремента над умножением");
            int d = 1;
            d = ++d * d;
            Console.WriteLine(d);

            Console.WriteLine("преоритет умножения над постфиксного инкремента ");
            int i = 1;
            i = i++ * i;
            Console.WriteLine(i);

            Console.WriteLine("преоритет 12");
            int x = 2;
            x = (x * x) * ++x;
            Console.WriteLine(x);

            Console.WriteLine("преоритет 24");
            int y = 2;
            y = ++y * (5 + y) ;
            Console.WriteLine(y);

        }
    }
}
