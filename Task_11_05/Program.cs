namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
        возвращает их сумму и произведение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            SummComp(ref num1, ref num2, out int summ, out int comp);
            Console.WriteLine($"Сумма: {summ}");
            Console.WriteLine($"Произведение: {comp}");

        }

        /// <summary>
        /// Записывает сумму и произведение двух чисел
        /// </summary>
        /// <param name="num1">первое число</param>
        /// <param name="num2">второе число</param>
        /// <param name="summ">сумма</param>
        /// <param name="comp">произведение</param>
        static void SummComp(ref int num1, ref int num2, out int summ, out int comp)
        {
            summ = num1 + num2;
            comp = num1 * num2;
        }


    }
}