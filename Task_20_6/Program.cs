namespace Task_20_06
{
    internal class Program
    {
        /*
         * Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
            • Red
            • Yellow
            • Green
            Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
            При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
            Добавьте возможность ручного переключения (например, по нажатию клавиши).
         */
        static void Main(string[] args)
        {
            TraficLight.ShowColor();
            while (true)
            {
                for (int i = 0; i <= 30; i += 1)
                {
                    Thread.Sleep(100);  // задержка 0.1с

                    // если нажат пробел сменить цвет
                    if (Console.KeyAvailable)
                    {
                        var input = Console.ReadKey(true).Key;
                        if (input == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            TraficLight.ChangeColor();
                            TraficLight.ShowColor();
                        }
                    }
                }

                // если прошли 3 секунды сменить цвет автоматически
                Console.Clear();
                TraficLight.ChangeColor();
                TraficLight.ShowColor();

            }
        }
    }
}