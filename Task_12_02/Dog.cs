using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Dog
    {
        public string breed; // порода
        public string name; // кличка
        public string age; // возраст
        public string color; // цвет
        bool isVaccine = true; // проверяет есть ли у собаки прививки
        bool isNotVaccine = true;


        // метод класса - выдает информацию о собаке
        public void DogInfo()
        {
            Console.WriteLine($"\n\nСобаке под кличкой {name} {age}, ее порода {breed}, а ее шерстка имеет {color} цвет");
        }

        // метод класса - проверяет наличие прививок
        public void IsVaccine()
        {
            if (isVaccine)
                Console.WriteLine($"Собака {name} имеет все прививки");
            else
                Console.WriteLine($"У собаки {name} нет прививок");
        }

        // метод класса - проверяет отсутствие прививок
        public void IsNotVaccine()
        {
            if (isNotVaccine)
                Console.WriteLine($"У собаки {name} нет прививок");
            else
                Console.WriteLine("У собаки есть все прививки");
        }
    }
}