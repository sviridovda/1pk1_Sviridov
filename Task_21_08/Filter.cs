using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_08
{
    /*
         * напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки
         */
    static class Filter
    {
        public static string[] FilterStrings(params string[] strs)
        {
            HashSet<string> set = new();
            string[] newStrs = new string[100];

            foreach (string str in strs)
                set.Add(str);

            int i = 0;
            while (set.Count != 0)
            {
                newStrs[i++] = set.First();
                set.Remove(set.First());
            }

            return newStrs;
        }
    }
}