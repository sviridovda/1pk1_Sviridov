namespace Task_04_10
{
    internal class Program
    {
        /*
        Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов
        отдельно для 1-ой и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
        использовать нельзя.
        Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
        Результат: [4,0,-10,2,5,-7,9,2,7,-6]
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas = new int[10];        // Исходный масссив
            int[] resMas = new int[10];     // результирующий массив

            // заполнение массива числами
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rnd.Next(-10, 11);

            int indexMiddleElem = mas.Length / 2 - 1; // индекс серединного элем. массива

            // идём от середины до 0
            for (int i = indexMiddleElem; i >= 0; i--)
                resMas[Math.Abs(i - indexMiddleElem)] = mas[i];

            // идём от конца до середины
            for (int i = resMas.Length - 1; i > indexMiddleElem; i--)
                resMas[resMas.Length - i + indexMiddleElem] = mas[i];

            // вывод
            Console.WriteLine("Исходный массив:");
            foreach (int i in resMas)
                Console.Write($"{i} ");

            Console.WriteLine("\nМассив с реверсом в 1ой и 2ой части:");
            foreach (int i in mas)
                Console.Write($"{i} ");

        }
    }
}