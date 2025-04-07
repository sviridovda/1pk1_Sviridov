namespace Task_21_02
{
    internal class Program
    {
        /*
         * Дан текст. 
         * Написать метод, который возвращает словарь, где ключ — слово, а значение —количество его вхождений в тексте.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // словарь со словами и кол-ом их вхождений в тексте
            Dictionary<string, int> dict = CountWords.CountOfWords(text);

            // вывод словаря
            foreach (var (k, v) in dict)
            {
                int len = k.Length;
                string space = "";
                for (int i = 0; i < 15 - len; i++) space += " ";

                Console.WriteLine($"Слово: \"{k}\";" + space + $"Кол-во вхождений: {v}.");
            }
        }
    }
}