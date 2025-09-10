using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Cat
    {
        public string breed; // порода
        public string name; // кличка
        public string age; // возраст
        public string color; // цвет
        bool isMother = true; // проверка на наличие котят
        bool childFree = true; // проверка на наличие котят

        // метод класса - выдает информацию о кошке
        public void CatInfo()
        {
            Console.WriteLine($"\n\nКошка под кличкой {name}: ее порода - {breed}, ее шерсть имеет {color} цвет, и ей {age}");
        }

        // метод класса - проверяет есть ли у кошки котята
        public void IsMother()
        {
            if (isMother)
                Console.WriteLine($"У кошки {name} есть котята");
            else
                Console.WriteLine("У кошки нет котят");
        }

        // метод класса - проверяет нет ли у кошки котят
        public void IsChildFree()
        {
            if (childFree)
                Console.WriteLine($"У кошки {name} нет котят");
            else
                Console.WriteLine("У кошки есть котята");
        }
    }
}