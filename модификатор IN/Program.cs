using System;

namespace модификатор_IN
{
    class Program
    {

        // in передаёт значение по ссылке но не позволяет его менять.Оно становится readonly
        // нужно для уменьшения количетсва использовованной оперативной памяти, увеличивает быстродействие
        static void Foo(in int a)
        {
           
        }

        static void Main(string[] args)
        {
            int a = 2;
            Foo(a);
            Console.WriteLine(a);
        }
    }
}
