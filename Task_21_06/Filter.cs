using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_06
{
    static class Filter
    {
        /// <summary>
        /// удаляет повторяющиеся элементы, сохраняя их порядок
        /// </summary>
        /// <param name="list"> список </param>
        public static void FilterList(List<int> list)
        {
            HashSet<int> set = new(list);
            List<int> newList = new(set);

            for (int i = 0; i < list.Count;)
            {
                if (i >= newList.Count) list.RemoveAt(i);
                else
                {
                    list[i] = newList[i];
                    i++;
                }
            }

        }
    }
}