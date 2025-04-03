namespace Task_20_04
{
    internal class Program
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
        static void Main(string[] args)
        {
            VehicleType truck1 = new VehicleType(Vehicle.Truck);
            truck1.ShowInfo();

            VehicleType truck2 = new VehicleType(Vehicle.Truck);
            VehicleType truck3 = new VehicleType(Vehicle.Truck);
            truck2.ShowInfo();

            VehicleType car1 = new VehicleType(Vehicle.Car);
            car1.ShowInfo();

            VehicleType bus1 = new VehicleType(Vehicle.Bus);
            VehicleType bus2 = new VehicleType(Vehicle.Bus);
            VehicleType bus3 = new VehicleType(Vehicle.Bus);
            VehicleType bus4 = new VehicleType(Vehicle.Bus);
            VehicleType bus5 = new VehicleType(Vehicle.Bus);
            bus1.ShowInfo();
        }
    }
}