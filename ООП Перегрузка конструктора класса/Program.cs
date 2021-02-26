using System;

namespace ООП_Перегрузка_конструктора_класса
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            _firstName  = firstName;
            _middleName = middleName;
            _lastName   = lastName;
            _birthday   = birthday;
        }
        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;
    public void Print()
    {
        Console.WriteLine($"Имя: {_firstName} \nФамилия: {_lastName} \nОтчество: {_middleName} \nДата рождения: {_birthday}");
    }
    }
    class Point
    {
        public Point()
        {
            _x = _y = 1;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\t Y: {_y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Point point = new Point(3,4);
            point.Print();
            Console.WriteLine();

            Student student_1 = new Student("Косяков", new DateTime(2020,10,5));

            Student student_2 = new Student(student_1);

            student_1.SetLastName("$$$$$$$$");

            student_1.Print();

            Console.WriteLine(); 

            student_2.Print();
            
        }
    }

}
