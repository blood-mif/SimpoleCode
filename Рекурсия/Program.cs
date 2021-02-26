using System;

namespace Рекурсия
{
    class Program
    {
        // рекурсия - вызов функции внутри функции
        // рекурсия ограничена размером стека (около 1мб)
        /*
        static void Foo()
        {
            Console.WriteLine("Hi");
            Foo();
        }
        */
        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i>=3)
            {
                return;
            }
            i++;
            Foo(i); 
        }

        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static void Print(Item item)
        {
            if (item!=null)
            {
            Console.WriteLine(item.Value);
            Print(item.Child);
            }
        }
        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }
        static void Main(string[] args)
        {
            Foo(0);
            Item item = InitItem();
            Print(item);
            //То же через цикл
            Console.WriteLine("То же через цикл");
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
