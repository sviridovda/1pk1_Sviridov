namespace Task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
        меняет их местами. Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 7;
            Console.WriteLine($"Числа: {num1}, {num2}");
            Reverse(ref num1, ref num2);
            Console.WriteLine($"Числа после замены: {num1}, {num2}");
        }
        /// <summary>
        /// Меняет числа местами
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        static void Reverse(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}