using System;

namespace Enum__перечисление_
{
    // Enum (перечисление)
    class Program
    {

        enum DayOfWeek //: byte // :byte изменили тип данных с инта на byte
        {
            Monday =1 ,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Friday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek);

            Console.WriteLine((DayOfWeek)2);

                DayOfWeek nextDay = GetNextDay(dayOfWeek);
                Console.WriteLine(nextDay);


            DayOfWeek dayOfWeek1;

            int value = 5;

            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek1 = (DayOfWeek)value; // приводим инт к DayOfWeek
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value.");
            }

            //список всех состояний ( значений ) Enum
            var values = Enum.GetValues(typeof(DayOfWeek)); 
           
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            //парсим enum

            string str = Console.ReadLine();
            DayOfWeek dayOfWeek2 = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase: true);
            
            Console.WriteLine(dayOfWeek2);





            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали enter!");
                }
                if (key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        
        }

        static DayOfWeek GetNextDay (DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
            {
                return day + 1;
            }
            return DayOfWeek.Monday;
        }


    }
}
