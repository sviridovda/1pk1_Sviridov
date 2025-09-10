namespace Task_21_10
{
    internal class Program
    {
        /*
         * Написать метод, который объединяет два словаря. 
         * Если ключ присутствует в обоих словарях, суммировать их значения.
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // словари
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();

            // ввод с консоли длины словарей
            int countDict1 = -1;
            while (countDict1 < 0 || countDict1 > 100)
            {
                Console.Write("Введите кол-во пар первого словаря (от 0 до 100) >> ");
                int.TryParse(Console.ReadLine(), out countDict1);
            }
            int countDict2 = -1;
            while (countDict2 < 0 || countDict2 > 100)
            {
                Console.Write("Введите кол-во пар второго словаря (от 0 до 100) >> ");
                int.TryParse(Console.ReadLine(), out countDict2);
            }

            // генерация словарей
            for (int i = 0; i < countDict1; i++)
            {
                int key = rnd.Next(0, 10);
                while (dict1.ContainsKey(key))  // обработка повторяющихся ключей
                    key = rnd.Next(0, 10);

                dict1[key] = rnd.Next(0, 101);
            }

            for (int i = 0; i < countDict2; i++)
            {
                int key = rnd.Next(0, 10);
                while (dict2.ContainsKey(key))  // обработка повторяющихся ключей
                    key = rnd.Next(0, 10);

                dict2[key] = rnd.Next(0, 101);
            }

            Dictionary<int, int> dict = Union.UnionDict(dict1, dict2);

            // вывод
            Console.Clear();
            Console.WriteLine("\nПервый словарь:");
            foreach (var (k, v) in dict1)
                Console.WriteLine($"{k} {v}");

            Console.WriteLine("\nВторой словарь:");
            foreach (var (k, v) in dict2)
                Console.WriteLine($"{k} {v}");

            Console.WriteLine("\nРезультирующий словарь:");
            foreach (var (k, v) in dict)
                Console.WriteLine($"{k} {v}");

        }
    }
}