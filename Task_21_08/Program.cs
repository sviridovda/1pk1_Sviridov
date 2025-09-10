namespace Task_21_08
{
    internal class Program
    {
        /*
         * напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки
         */
        static void Main(string[] args)
        {
            string[] strs = new string[100];

            Console.WriteLine("Введите последовательность строк (не более 100), оканчивающуюся пустой строкой:");

            int i = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "" || i >= strs.Length) break;
                strs[i++] = str;
            }

            string[] newStrs = Filter.FilterStrings(strs);

            Console.WriteLine("Обновлённая последовательность строк:");
            foreach (string str in newStrs)
                if (str != null) Console.WriteLine(str);
        }
    }
}