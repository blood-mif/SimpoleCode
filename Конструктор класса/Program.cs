using System;

namespace Конструктор_класса
{

    class Gun
    {
        public Gun(bool isLoaded)
        {
            //isLoaded = true;
            // Reload();

            _isLoaded = isLoaded;


        }

        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("Заряжено!");
        }
        public void Shoot()
        {
            if(!_isLoaded)
            {
                Console.WriteLine("Орудие не заряжено");
                Reload();
            }
            Console.WriteLine("Пыщ-пыщ\n");
            _isLoaded = false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: true);
            gun.Shoot();
            gun.Shoot();
        }
    }
}
