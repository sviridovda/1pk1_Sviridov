namespace Task_04_06
{
    internal class Program
    {
        /*
        Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
        модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
        двух равных по модулю. В полученном массиве найти наибольшее по модулю число.
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[20];        // результирующий массив 
            int[] outnumbers = new int[20];     // массив использованных чисел

            int rndnum = 0; // рандомное число
            int i = 0;      // параметр цикла
            while (i < numbers.Length)
            {
                rndnum = rnd.Next(-20, 21);

                // если число есть в массиве использованных чисел или оно 0 пропустить итерацию
                if (Array.IndexOf(outnumbers, Math.Abs(rndnum)) != -1 || rndnum == 0)
                    continue;

                // добавление чисел в массивы
                outnumbers[i] = Math.Abs(rndnum);
                numbers[i] = rndnum;
                i++;
            }

            // нахождение максимального числа по модулю
            int maxnum = 0;
            foreach (int j in numbers)
                if (Math.Abs(maxnum) < Math.Abs(j))
                    maxnum = j;

            Console.WriteLine($"Число: {maxnum} наибольшее по модулю.");
        }
    }
}