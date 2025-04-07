namespace Task_21_06
{
    internal class Program
    {
        /*
         * Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
         */
        static void Main(string[] args)
        {
            List<int> list = new();

            Console.WriteLine("Введите последовательность оканчивающуюся 0:");

            // ввод с консоли и запись в список чисел
            while (true)
            {
                int elem;
                int.TryParse(Console.ReadLine(), out elem);
                if (elem == 0) break;
                list.Add(elem);
            }

            Console.Clear();
            Console.WriteLine("Старый список:");
            foreach (int el in list)
                Console.Write($"{el} ");

            Filter.FilterList(list);

            Console.WriteLine("\nОбновлённый список:");
            foreach (int el in list)
                Console.Write($"{el} ");
        }
    }
}