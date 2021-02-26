using System;
using System.Reflection;
namespace Модификаторы_доступа_public_и_private
{
    class Point
    {
        int z = 13;
        public int x =3;

        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y {y}");
        }

      public void PrintPoint()
        {
            PrintX();
            PrintY();
        }

        


    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.PrintPoint();
            
            Console.WriteLine();
            Console.WriteLine();

            var typeInfo = typeof(Point).GetFields
                (BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t  IsPrivet: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }
        }
    }
}
