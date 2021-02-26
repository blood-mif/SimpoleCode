using System;

namespace Логические_операторы
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Логические операторы
         

            &&        Сокращённое И     (все параметры,если первый оперант удолетворяет условия, второй и далее не рассматривают, так шустрее)
            ||        Сокращённое ИЛИ   (хотя бы один из параметров)
            &         И                 (проверяют все условия, даже если первый оперант уже НЕ удолетворяет условия,тормозят систему)
            |         ИЛИ               (проверяют все условия, даже если первый оперант уже удолетворяет условия,тормозят систему)
            !         НЕ (унарный) 
             */

            bool isHightTemperature = true;
            bool hasNoCooling = true;
            int fanSpeed = 3000;
            bool hasNoCooling1 = fanSpeed <= 0;

            if (isHightTemperature && hasNoCooling)
            {
                Console.WriteLine("Угроза перегрева!!! =&&");
            }
            if (isHightTemperature || hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =||");
            }
            if (isHightTemperature | hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =|");
            }
            if (isHightTemperature & hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =&");
            }



        }
    }
}
