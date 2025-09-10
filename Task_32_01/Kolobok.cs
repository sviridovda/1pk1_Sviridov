using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; private set; }
        public bool IsAlive { get; private set; }
        public bool IsStop { get; private set; }

        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }

        // колобок покатился
        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");

        }

        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

        public void MeetObstacle(Obstacle obstacle)
        {
            if (obstacle.UnSpeed(this))
            {
                Speed = 0;
                Console.WriteLine($"Колобок не смог преодолеть препятствие {obstacle.Name}");
            }
            else
            {
                Console.WriteLine($"Колобок преодолел препятствие {obstacle.Name}");
            }
        }
    }
}
