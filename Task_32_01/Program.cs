using System;
using static System.Formats.Asn1.AsnWriter;

namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
                new Hare(),
                new Wolf(),
                new Bear(),
                new Fox()
            };

            List<Obstacle> obstacles = new List<Obstacle>
            {
                new Stone(),
                new Puddle(),
                new Lake()
            };

            foreach (var animal in animals)
            {
                if (!kolobok.IsAlive)
                    break;
                kolobok.Roll();
                kolobok.MeetAnimal(animal);

                kolobok.MeetObstacle(obstacles[rnd.Next(0, 3)]);
                if (kolobok.Speed == 0)
                    break;
            }

            if (kolobok.IsAlive && kolobok.Speed != 0)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else if (kolobok.Speed == 0)
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }



        }
    }
}