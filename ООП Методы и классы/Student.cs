using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_Методы_и_классы
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация: ");
            Console.WriteLine($" Имя      {firstName}");
            Console.WriteLine($" Фамилия  {lastName}");
            Console.WriteLine($" Отчество {middleName}");
            Console.WriteLine($" Возраст  {age}");
            Console.WriteLine($" Группв   {group}");
            Console.WriteLine($" ID :     {id}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }

    }
}
