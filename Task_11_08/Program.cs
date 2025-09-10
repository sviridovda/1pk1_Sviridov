namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное количество
        чисел и возвращает их сумму и максимальное значение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 6, 3, 13, 73, 18, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            SummMax(out int summ, out int max, array);
            Console.WriteLine(summ);
            Console.WriteLine(max);

        }

        /// <summary>
        /// находит сумму чисел и максимальное число
        /// </summary>
        /// <param name="summ">сумма</param>
        /// <param name="max">максимальное число</param>
        /// <param name="array">числа</param>
        static void SummMax(out int summ, out int max, params int[] array)
        {
            summ = 0;
            max = 0;

            foreach (int i in array)
            {
                summ += i;
                if (i > max)
                    max = i;
            }
        }
    }
}