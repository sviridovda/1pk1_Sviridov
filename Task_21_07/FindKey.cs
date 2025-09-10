using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_07
{
    /*
     * Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. 
     * Если значения нет, вернуть null.
     */
    enum Keys
    {
        None,
        Key1,
        Key2,
        Key3,
        Key4,
        Key5
    }
    enum Values
    {
        Value1 = 1,
        Value2,
        Value3
    }
    static class FindKey
    {
        public static Dictionary<Keys, Values> dict = new Dictionary<Keys, Values>()
            {
                { Keys.Key1, Values.Value1 },
                { Keys.Key2, Values.Value2 },
                { Keys.Key3, Values.Value3 },
                { Keys.Key4, Values.Value2 },
                { Keys.Key5, Values.Value3 }
            };

        /// <summary>
        /// Возвращает первый ключ словаря по значению
        /// </summary>
        /// <param name="value"> значение </param>
        /// <returns></returns>
        public static Keys GetKeyForValue(Values value)
        {
            for (int i = 1; i < dict.Count; i++)
                if (dict[(Keys)i] == value) return (Keys)i;

            return Keys.None;
        }
    }
}
