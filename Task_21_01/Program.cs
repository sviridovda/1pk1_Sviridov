namespace Task_21_01
{
    internal class Program
    {
        /*
         * Дан список чисел. 
         * Создать новый список, содержащий только чётные числа из исходного списка, умноженные на 10.
         */
        static void Main(string[] args)
        {
            List<int> list = new(); // список чисел

            Console.WriteLine("Введите последовательность оканчивающуюся 0:");

            // запрос с консоли последовательности и запись её в список
            while (true)
            {
                int n;
                if (!int.TryParse(Console.ReadLine(), out n) || n == 0)
                {
                    Console.Clear();
                    break;
                }
                list.Add(n);
            }

            // вывод исходного списка
            Console.WriteLine("Исходный список:");
            foreach (int el in list)
                Console.Write($"{el} ");

            Filter.FilterList(list);

            // вывод отфильтрованнок списка
            Console.WriteLine("\nОтфильтрованный список:");
            foreach (int el in list)
                Console.Write($"{el} ");
        }
    }
}