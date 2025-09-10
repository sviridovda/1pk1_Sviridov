using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_10
{
    static class Union
    {
        /// <summary>
        /// Возвращает словарь с суммами значений двух словарей
        /// </summary>
        /// <param name="dict1"> словарь 1 </param>
        /// <param name="dict2"> словарь 2 </param>
        /// <returns> результирующий словарь </returns>
        public static Dictionary<int, int> UnionDict(Dictionary<int, int> dict1, Dictionary<int, int> dict2)
        {
            Dictionary<int, int> dict = new();

            foreach (var (k, v) in dict1)
            {
                if (!dict.ContainsKey(k)) dict[k] = 0;
                dict[k] += v;
            }
            foreach (var (k, v) in dict2)
            {
                if (!dict.ContainsKey(k)) dict[k] = 0;
                dict[k] += v;
            }

            return dict;
        }
    }
}