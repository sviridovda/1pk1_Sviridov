namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ускорение свободного падения
            const double g = 9.8; // м/с^2
                                  // Начальные значения
            double startTime = 0.0; // Начальное время (в секундах)
            double endTime = 5.0;    // Конечное время (в секундах)
            double step = 0.5;       // Шаг времени (в секундах)

            // Заголовок таблицы
            Console.WriteLine($"{"t (с)",-10} | {"v (м/с)",-10}");
            Console.WriteLine(new string('-', 25));

            // Вывод таблицы значений скорости
            for (double t = startTime; t <= endTime; t += step)
            {
                double v = g * t; // Вычисляем скорость v = g * t
                Console.WriteLine($"{t,-10:F1} | {v,-10:F2}");
            }
        }
    }
}
    

