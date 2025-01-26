namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            double startCelsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double endCelsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры в градусах Цельсия: ");
            double step = Convert.ToDouble(Console.ReadLine());

            // Вывод заголовка таблицы
            Console.WriteLine("\nТемпература (°C) | Температура (°F)");
            Console.WriteLine("-------------------|-------------------");

            // Цикл для вычисления и вывода значений
            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,-18:F2} | {fahrenheit,-18:F2}");
            }
        }
    }
}

