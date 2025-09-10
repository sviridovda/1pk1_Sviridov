namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Pet
            Pet pet = new Pet();
            Pet pet2 = new Pet("bobic", "ovcharka", 4, 15, true);

            pet2.WriteInfo();

            pet.Healthy = false;
            pet.Weight = 1;

            pet.WriteInfo();
            #endregion

            #region Class Car
            Car car = new Car("a 567 py", "mark", "Blue", 45);

            car.Drive(5);
            #endregion
        }
    }
}