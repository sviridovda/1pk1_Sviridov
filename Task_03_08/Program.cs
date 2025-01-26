namespace Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Перебираем числа от 20 до 50
            for (int i = 20; i <= 50; i++)
            {
                // Проверяем, делится ли число на 3 и не делится ли на 5
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i); // Выводим число
                }
            }
        }
    }
}
    

