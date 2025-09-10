namespace Task_04_05
{
    internal class Program
    {
        /*
          В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
          количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
          отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
          осадков, до 300 мм выпавших осадков.
        */
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] precs = new int[30];

            int decad1 = 0;     // первая декада
            int decad2 = 0;     // вторая декада
            int decad3 = 0;     // третья декада
            int maxPrec = 0;    // максимальное количество осадков
            int dayMaxPrec = 0; // день максимального количества осадков

            for (int i = 0; i < precs.Length; i++)
            {
                precs[i] = random.Next(0, 301);

                // заполнение декад осадками по дню
                if (i < 10)
                    decad1 += precs[i];
                else if (i >= 20)
                    decad3 += precs[i];
                else
                    decad2 += precs[i];

                if (maxPrec < precs[i])
                {
                    maxPrec = precs[i];
                    dayMaxPrec = i;
                }

                // вывод дней без осадков
                if (precs[i] == 0)
                    Console.WriteLine($"{i + 1} день без осадков");
            }

            Console.WriteLine($"За первую декаду месяцев выпало: {decad1}мм осадков\nЗа вторую: {decad2}\nЗа третью: {decad3}");
            Console.WriteLine($"{dayMaxPrec} числа выпало рекордное количество осадков: {maxPrec}мм");
        }
    }
}