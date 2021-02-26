using System;

namespace ООП_Методы_и_классы
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.age = 21;
            student.firstName = "Vasily";
            student.middleName = "Mikhalovich";
            student.group = "IT-32";
            student.lastName = "Peperelkin";
            student.id = Guid.NewGuid();

            return student;
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();
            Console.WriteLine();
            Console.WriteLine();

            var secontStudet = new Student();
            secontStudet.firstName = "Mark";
            secontStudet.Print();
            
            Console.WriteLine();
            Console.WriteLine();

            string fullName = firstStudent.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}
