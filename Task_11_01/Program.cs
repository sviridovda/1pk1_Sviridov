namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
        местами. Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 7;
            Console.WriteLine($"Числа: {num1}, {num2}");
            Reverse(num1, num2);
            Console.WriteLine($"Числа после замены местами: {num1}, {num2}");
        }

        /// <summary>
        /// Меняет числа местами
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>

        static void Reverse(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}