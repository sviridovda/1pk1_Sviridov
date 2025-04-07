using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_02
{
    static class CountWords
    {
        /// <summary>
        /// разбивает текст на слова
        /// создаёт словарь с ключом строкой и целочисленным значением
        /// делает подсчёт вхождений слов в тексте
        /// </summary>
        /// <param name="text"> текст </param>
        /// <returns></returns>
        public static Dictionary<string, int> CountOfWords(string text)
        {
            Dictionary<string, int> dict = new();

            // разбитый на слова текст
            string[] textSplit = text.Split('.', ',', ':', ';', '?', '!', '\'', '"', '(', ')', '%', '$', ' ');
            for (int i = 0; i < textSplit.Length; i++)
            {
                string strKey = textSplit[i];                       // слово
                if (!dict.ContainsKey(strKey)) dict[strKey] = 0;    // создание новой пары ключа значения

                dict[strKey]++;
            }

            return dict;
        }
    }
}
