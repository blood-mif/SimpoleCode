using System;


namespace ООП_Классы__обьект_класса
{
    /// <summary>
    /// ООП
    /// Класс
    /// Обьект класса
    /// </summary>
    /// 

    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Black
    }



    class Point
    {
        public int x; // переменная внутри класса называется полем
        public int y;
        public Color color;

    }

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



        static void Print(Student student) 
        {
            Console.WriteLine("Информация: ");
            Console.WriteLine($" Имя      {student.firstName}");
            Console.WriteLine($" Фамилия  {student.lastName}");
            Console.WriteLine($" Отчество {student.middleName}");
            Console.WriteLine($" Возраст  {student.age}");
            Console.WriteLine($" Группв   {student.group}");
            Console.WriteLine($" ID :     {student.id}");                            

        }
        static void Main(string[] args)
        {

            var firstStudent = GetStudent();

            Print(firstStudent);








            ///////////////////////////////////////////////////////////////////////
            Point p = new Point(); // p - это экземпляр класса ( обьект класса )
            p.x = 4;
            p.y = 2;
            p.color = Color.Red;


            Console.WriteLine($"x: {p.x} | y: {p.y} | Color: {p.color}");
            Point p2 = new Point();

            //p2 = null;
            ////null разрывает связь между управляющей кучей и ссылкой, переприсвоить значние после нельзя
            //p2.x = 2;
            //p2.y = 6;



        }

    }
}