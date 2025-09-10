using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    /*
     * создайте класс автомобиля
       свойства:
       номер авто, марка, цвет, текущая скорость
    методы:
    езда (симитировать равномерное ускорение скорости автомобиля)
    торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
    конструторы
    предусмотрите разные варианты инициализации объектов
    */
    internal class Car
    {
        string stateNumber;
        string mark;
        string color;
        int speed;

        public Car() { }

        public Car(string stateNumber) { this.stateNumber = stateNumber; }

        public Car(string stateNumber, string mark, string color, int speed)
        {
            this.stateNumber = stateNumber;
            this.mark = mark;
            this.color = color;
            this.speed = speed;
        }

        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string StateNumber
        {
            get => stateNumber;
            set => stateNumber = value;
        }

        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public string Mark
        {
            get => mark;
            set => mark = value;
        }

        /// <summary>
        /// Цвет автомобиля
        /// </summary>
        public string Color
        {
            get => color;
            set => color = value;
        }

        /// <summary>
        /// Скорость автомобиля
        /// </summary>
        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public void Drive(int delta)
        {
            while (true)
            {
                if (speed - 20 >= 60)
                {
                    Break();
                    break;
                }

                speed += delta;
                Console.WriteLine(speed);
            }
        }

        void Break()
        {
            int share = speed;
            for (int i = 0; i < 3; i++)
            {
                speed -= share / 3 + 1;
                if (speed < 0) speed = 0;
                Console.WriteLine(speed);
            }

        }
    }
}