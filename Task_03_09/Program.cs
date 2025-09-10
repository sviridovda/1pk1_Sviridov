namespace Task_03_09
{
    internal class Program
    {
        /*
          Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
          отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
          менее y рублей.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада, годовые проценты и желанную сумму.");
            double x = Convert.ToDouble(Console.ReadLine());    // первоначальная сумма
            double p = Convert.ToDouble(Console.ReadLine());    // проценты годовых
            double y = Convert.ToDouble(Console.ReadLine());    // сумма желанная к получению

            int countYear = 0;  // счётчик лет
            while (true)
            {
                if (x >= y)
                    break;

                x += x * p / 100;

                countYear++;
            }

            Console.WriteLine($"Через {countYear} оборотов Земли вокруг Солнца вклад составит не менее {y}руб.");
        }
    }
}