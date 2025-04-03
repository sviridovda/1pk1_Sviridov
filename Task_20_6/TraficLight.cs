using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    enum TraficLightColor
    {
        Red,
        Yellow,
        Green
    }
    internal static class TraficLight
    {
        static TraficLightColor lightColor = TraficLightColor.Red;
        static bool isStart = true; // если светофор переходит с красного на зелёный

        /// <summary>
        /// смена цвета
        /// </summary>
        public static void ChangeColor()
        {
            if (isStart) lightColor++;
            else lightColor--;

            if ((int)lightColor == 2) isStart = false;      // переключение с зелёного на красный
            else if ((int)lightColor == 0) isStart = true;  // переключение с красного на зелёный
        }

        /// <summary>
        /// вывод цвета в консоль
        /// </summary>
        public static void ShowColor()
        {
            ConsoleColor consoleColor;

            // выбор активного цвета
            switch (lightColor)
            {
                case TraficLightColor.Red:
                    consoleColor = ConsoleColor.Red;
                    break;
                case TraficLightColor.Yellow:
                    consoleColor = ConsoleColor.Yellow;
                    break;
                case TraficLightColor.Green:
                    consoleColor = ConsoleColor.Green;
                    break;
                default:
                    consoleColor = ConsoleColor.Black;
                    break;
            }

            Console.BackgroundColor = consoleColor;

            // отображение квадрата
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                    Console.Write("  ");

                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;

            //for (int i = -10; i <= 10; i++)
            //{
            //    int index = 10 - Math.Abs(i);
            //    for (int j = -10; j <= 10; j++)
            //    {
            //        if (10 - Math.Abs(j) == Math.Abs(i))
            //        {
            //            if (Console.BackgroundColor == ConsoleColor.Black) Console.BackgroundColor = consoleColor;
            //            else Console.BackgroundColor = ConsoleColor.Black;
            //        }

            //        Console.Write("  ");

            //        if (10 - Math.Abs(j) == Math.Abs(i) && Math.Abs(i) == 0) Console.BackgroundColor = ConsoleColor.Black;
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}