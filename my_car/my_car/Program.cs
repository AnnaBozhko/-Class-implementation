using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_car
{
    class Person
    {
        public string marka;
        public string model;
        public int age;
        public string body;
        public string engine;
        public string Transmission;
        public string Drive;
        public string Colour;
        public string security;
        public string comfort;
        

        public void GetInfo()
        {
            Console.WriteLine($"Марка авто: {marka}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Год выпуска: {age}");
            Console.WriteLine($"Кузов: {body}");
            Console.WriteLine($"Двигатель: {engine}");
            Console.WriteLine($"Коробка передач: {Transmission}");
            Console.WriteLine($"Привод: {Drive}");
            Console.WriteLine($"Цвет: {Colour}");
            Console.WriteLine($"Безопасность: {security}");
            Console.WriteLine($"Комфорт: {comfort}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Person Renault = new Person { marka = "Renault", model="Megane-3", age = 2013, body="Универсал",
                engine="Дизель", Transmission="Автоматическая",Drive="Передний", Colour="Белый металлик",
                security="Подушки безопасности, ABS, ABD, ESP, ЦЗ, сигнализация",comfort="Усилитель руля, кожаный салон, бортовой компьютер,кондиционер, климат контроль, круиз контроль, партроник, подогрев зеркал, GPS, MP3, DVD, тонирование стекол"
            };
            Renault.GetInfo();

            Console.Read();
        }
    }
}
