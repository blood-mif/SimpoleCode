using System;
using System.Linq;

namespace КЛЮЧЕВОЕ_СЛОВО_REF
{
    class Program
    {
        //ref передаёт значения параметра по ссылке, позволяет возвращать сразу столько значений, сколько задаёте через ref в одном методе
        static void Foo(ref int a)
        {
            a = -5;
        }

        static void Main(string[] args)
        {
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);
        }
    }
}
