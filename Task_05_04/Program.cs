namespace Task_05_04
{
    internal class Program
    {
        /*
        Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагональной. 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы N*N:");
            int n = int.Parse(Console.ReadLine());  // размерность марицы

            Random rnd = new Random();
            int[,] matric = new int[n, n];  // матрица
            bool matricIsDiog = true;       // переменная для проверки диагональности матрицы

            // заполнение матрицы рандомными числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matric[i, j] = rnd.Next(0, 10);

                    // проверка матрицы на диагональность
                    if (i != j && matric[i, j] != 0)
                        matricIsDiog = false;
                    else if (i == j && matric[i, j] == 0)
                        matricIsDiog = true;
                }
            }

            // вывод
            if (matricIsDiog == false)
                Console.WriteLine("Матрица не диогональна!");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // подсветка диагональных элементов
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.Write($"{matric[i, j]} ");
                        // возвращение в прежний вид
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}