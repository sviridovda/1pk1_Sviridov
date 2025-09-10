namespace Task_21_07
{
    internal class Program
    {
        /*
         * Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. 
         * Если значения нет, вернуть null
         */
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Введите значение >> ");
                int value;
                int.TryParse(Console.ReadLine(), out value);

                if (!FindKey.dict.ContainsValue((Values)value)) Console.WriteLine("Такого значения нет");   // обработка ошибочного значения
                else Console.WriteLine(FindKey.GetKeyForValue((Values)value));
            }
        }
    }
}