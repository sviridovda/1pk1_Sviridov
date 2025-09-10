using Task_12_02.Publications;


namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat() { name = "Снежка", age = "3 года", breed = "Мейн-кун", color = "белый" };
            var cat2 = new Cat() { name = "Луна", color = "серый", breed = "Русская голубая", age = "5 лет" };

            cat1.CatInfo(); // получение информации о первой кошке
            cat1.IsMother(); // проверка на наличие котят у первой кошки

            cat2.CatInfo(); // получение информации о второй кошке
            cat2.IsChildFree(); // проверка на отсутствие котят у второй кошки


            var dog1 = new Dog() { name = "Арчи", age = "8 лет", breed = "такса", color = "черный" };
            var dog2 = new Dog() { name = "Эльза", breed = "бульдог", age = " 4 года", color = "серый" };

            dog1.DogInfo(); // получение информации о первой собаки
            dog1.IsNotVaccine(); // проверка на отсутствие прививок

            dog2.DogInfo(); // получение информации о второй собаке
            dog2.IsVaccine(); // проверка на наличие прививок 
        }
    }
}