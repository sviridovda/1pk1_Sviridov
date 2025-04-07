namespace Task_21_04
{
    internal class Program
    {
        /*
         * Дан SortedSet<int>. 
         * Написать метод, который возвращает подмножество элементов, ключи которых лежат в заданном диапазоне [start, end].
         */
        static void Main(string[] args)
        {
            SortedSet<int> set = new();

            Console.WriteLine("Введите последовательность элементов множества заканчивающуюся 0:");

            // ввод элементов с консоли м добавление в множество
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int elem);
                if (elem == 0) break;
                set.Add(elem);
            }
            Console.Clear();

            Console.Write("Введите нижнюю границу >> ");
            int.TryParse(Console.ReadLine(), out int start);

            Console.Write("Введите нижнюю границу >> ");
            int.TryParse(Console.ReadLine(), out int end);

            SortedSet<int> subSet = set.GetViewBetween(start, end); // обрез множества до подмножества

            // вывод
            Console.Clear();
            Console.WriteLine($"Подмножество элементов в диопазоне от {start} до {end}:");
            foreach (int el in subSet)
                Console.Write($"{el} ");

        }
    }
}