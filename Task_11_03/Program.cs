namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
        выходной параметр количество гласных и согласных букв в этой строке
         */
        static void Main(string[] args)
        {
            //Получение строки
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            //Количество гласных 
            int countVowels;
            //Количество согласных
            int countConsonant;

            CountLetters(text, out countVowels, out countConsonant);

            Console.WriteLine($"Количество гласных: {countVowels}");
            Console.WriteLine($"Количество согласных: {countConsonant}");

        }

        /// <summary>
        /// Находит число гласных и согласных в строке
        /// </summary>
        /// <param name="text">строка</param>
        /// <param name="countVowels">количество гласных</param>
        /// <param name="countConsonant">количество согласных</param>
        static void CountLetters(string text, out int countVowels, out int countConsonant)
        {
            countVowels = 0;
            countConsonant = 0;

            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string consonant = "бвгджзйклмнопрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                { countVowels++; }
                if (consonant.Contains(c))
                { countConsonant++; }
            }
        }
    }
}