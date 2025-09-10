using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    /*создать класс питомца
    свойства:
    кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
    методы:
    вывод информации об объекте
    изменение значения веса животного
    изменение отметки о состоянии здоровья
    конструторы:
    предусмотрите разные варианты инициализации объектов 
    */
    internal class Pet
    {
        string Nickname { get; set; }
        string Species { get; set; }
        int Age { get; set; }
        int weight;
        bool healthy;

        public Pet() { }

        public Pet(string nickname) { Nickname = nickname; }

        public Pet(string nickname, string species, int age, int weight, bool healthy)
        {
            Nickname = nickname;
            Species = species;
            Age = age;
            this.weight = weight;
            this.healthy = healthy;
        }



        /// <summary>
        /// Изменение значения веса
        /// </summary>
        public int Weight { set => weight = value; }

        /// <summary>
        /// Изменение отметки о здоровье
        /// </summary>
        public bool Healthy { set => healthy = value; }

        /// <summary>
        /// Вывод всей информации об
        /// </summary>
        public void WriteInfo()
        {
            string healthy = this.healthy ? "Да" : "Нет";
            Console.WriteLine($"Кличка: {Nickname}\nВид: {Species}\nВозраст: {Age}\nВес: {weight}\nЗдоров: {healthy}");
        }
    }
}