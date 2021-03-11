using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HuntTheWumpus_2
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepository repository = new Repository();

            //IRepository repository = new FilesRepository();

            var person1 = new Person
            {
                Id = 1,
                Name = "Test",
                Age = 20
            };
            var person2 = new Person
            {
                Id = 2,
                Name = "Test2",
                Age = 22
            };

            repository.AddPerson(person1);
            repository.AddPerson(person2);

            Console.WriteLine();

            var listPerson = repository.GetAllPersons();

            Console.WriteLine();

            Console.ReadKey();


        }
    }

    public interface IRepository
    {
        List<Person> GetAllPersons();
        void AddPerson(Person person);
        void DeletePersn(int id);
    }

    public class Repository : IRepository
    {
        private List<Person> list;
        public Repository()
        {
            list = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            list.Add(person);
        }

        public void DeletePersn(int id)
        {
            var person = list.FirstOrDefault(p => p.Id == id);
            list.Remove(person);
        }

        public List<Person> GetAllPersons()
        {
            return list;
        }
    }

    public class FilesRepository : IRepository
    {
        private List<Person> list = new List<Person>();

        string dir = Directory.GetCurrentDirectory();
        string filename = "test.txt";

        string path;

        public FilesRepository()
        {
            path = Path.Combine(dir, filename);
        }

        public void AddPerson(Person person)
        {
            using (StreamWriter sw = new StreamWriter(path))

                sw.WriteLine(person.ToString());
        }

        public void DeletePersn(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }
    }
}
