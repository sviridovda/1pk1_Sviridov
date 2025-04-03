using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    enum Vehicle
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }

    internal class VehicleType
    {
        /*
         * Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
            • Car
            • Bike
            • Bus
            • Truck
            • Motorcycle
            Храните список транспортных средств (можно просто List<VehicleType>). 
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
        Реализуйте поиск по типу и вывод информации.
         */

        Vehicle vehicle;
        static List<Vehicle> vehicleType = new List<Vehicle>();
        static List<int> vehicleTypeCount = new List<int>() { 0, 0, 0, 0, 0 };

        /// <summary>
        /// добавление транспорта 
        /// увеличение кол-во его типа
        /// и инициализация поля типом транспорта
        /// </summary>
        /// <param name="vehicle"></param>
        public VehicleType(Vehicle vehicle)
        {
            vehicleType.Add(vehicle);
            vehicleTypeCount[(int)vehicle]++;
            this.vehicle = vehicle;
        }

        public void ShowInfo()
        {
            int countType = vehicleTypeCount[(int)vehicle]; // количество штук типа

            // выбор нужной формs слова штука
            string piece;
            switch (countType)
            {
                case >= 5:
                    piece = "штук";
                    break;
                case >= 2:
                    piece = "штуки";
                    break;
                default:
                    piece = "штука";
                    break;
            }

            Console.WriteLine($"{vehicle} сейчас в наличии {countType} {piece}");
        }

    }
}