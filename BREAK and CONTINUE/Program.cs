using System;

namespace BREAK_and_CONTINUE
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(i);
                string msg = Console.ReadLine();
                if (msg == "stop")
                {
                    break;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Сейчас i = " + i);
                    continue;
                    Console.WriteLine("А этой надписи вы не увидите, всё что после  Continue не выполняется");
                }
                Console.WriteLine(i);
            }
        }
    }
}
