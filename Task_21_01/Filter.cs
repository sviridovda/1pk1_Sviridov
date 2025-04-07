using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_01
{
    static class Filter
    {
        /// <summary>
        /// фильтрует список, удаляя нечётные числа
        /// и умножая чётные на 10
        /// </summary>
        /// <param name="lst"> список </param>
        public static void FilterList(List<int> lst)
        {
            for (int i = 0; i < lst.Count;)
            {
                if (lst[i] % 2 != 0) lst.RemoveAt(i);
                else
                {
                    lst[i] *= 10;
                    i++;
                }
            }
        }
    }
}