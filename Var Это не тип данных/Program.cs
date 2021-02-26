using System;

namespace Var_Это_не_тип_данных
{

    // ключевое слово var
    // неявно типизированные локальные переменные

    class Program
    {
        static int Sum(int a, int b)
        {
            var result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            
            var a = "Hi";
            // используется только для локальный переменных какого либо метода

            var t = Sum(2,3);

            Console.WriteLine(a.GetType());
        }
    }
}
