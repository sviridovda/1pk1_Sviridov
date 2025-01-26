namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем начальные значения
            double start = -4.0;
            double end = 4.0;
            double step = 0.5;

            // Заголовок таблицы
            Console.WriteLine($"{"x",-10} | {"y",-10}");
            Console.WriteLine(new string('-', 25));

            // Вывод таблицы значений функции
            for (double x = start; x <= end; x += step)
            {
                double y = Math.Abs(x); // Вычисляем значение функции y = |x|
                Console.WriteLine($"{x,-10:F2} | {y,-10:F2}");
            }
        }
    }
}
    

