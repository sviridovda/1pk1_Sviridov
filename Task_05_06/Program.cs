namespace Task_05_06
{
    internal class Program
    {
        /*
         * Осуществить генерация двумерного [10*5] массива по следующему правилу:
            • 1 столбец содержит нули
            • 2 столбце содержит числа кратные 2
            • 3 столбец содержит числа кратные 3
            • 4 столбец содержит числа кратные 4
            • 5 столбец содержит числа кратные 5
           Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mas = new int[10, 5];        // исходный массив
            int[,] newMas = new int[5, 10];     // результирующий массив

            // заполнение исходного массива
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = j * (j + 1);

            // транспонирование массива и вывод
            for (int i = 0; i < newMas.GetLength(0); i++)
            {
                for (int j = 0; j < newMas.GetLength(1); j++)
                {
                    newMas[i, j] = mas[j, i];
                    Console.Write($"{newMas[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}