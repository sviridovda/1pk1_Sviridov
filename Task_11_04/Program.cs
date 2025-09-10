namespace Task_11_04
{
    internal class Program
    {
        /*
        Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
        их среднее значение. Используйте ключевое слово params
         */
        static void Main(string[] args)
        {
            int[] array = new int[10]; //Создание массива
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++) //Заполнение массива
            {
                array[i] = rnd.Next(0, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Среднее значение: ");
            Console.WriteLine(AvarageValue(array)); //Вывод
        }

        /// <summary>
        /// Находит среднее значение массива чисел
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns></returns>
        static int AvarageValue(params int[] array)
        {
            int summ = 0;
            foreach (int number in array)
                summ += number;
            int value = summ / array.Length;
            return value;



        }
    }
}