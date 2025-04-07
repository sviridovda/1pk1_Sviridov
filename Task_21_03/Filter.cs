using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_03
{
    /*
         * создайте класс Book и сгенерируйте список объектов книг (минимум 100 элементов). проанализируйте список и выведите:
            книгу с самым ранним годом издания (если их несколько то все)
            книгу с самым поздним годом издания (если их несколько то все)
            только книги в жанре «фантастика»
            только книги в состоянии «выданы на руки»
         */
    static class Filter
    {
        /// <summary>
        /// возвращает список книг с самым ранним годом издания
        /// </summary>
        /// <param name="books"> объект Book </param>
        /// <returns> список Book </returns>
        public static List<Book> GetMinYearOfPublication()
        {
            List<Book> minYearofPub = new();

            int minYear = DateTime.Now.Year;
            foreach (Book book in Book.Books)
                if (book.YearOfPublication < minYear) minYear = book.YearOfPublication;

            foreach (Book book in Book.Books)
                if (book.YearOfPublication == minYear) minYearofPub.Add(book);

            return minYearofPub;
        }

        /// <summary>
        /// возвращает список книг с самым поздним годом издания
        /// </summary>
        /// <param name="books"> объект Book </param>
        /// <returns> список Book </returns>
        public static List<Book> GetMaxYearOfPublication()
        {
            List<Book> maxYearofPub = new();

            int maxYear = 0;
            foreach (Book book in Book.Books)
                if (book.YearOfPublication > maxYear) maxYear = book.YearOfPublication;

            foreach (Book book in Book.Books)
                if (book.YearOfPublication == maxYear) maxYearofPub.Add(book);

            return maxYearofPub;
        }

        /// <summary>
        /// Возвращает список с книгами жанром фантастика
        /// </summary>
        /// <returns> список Book </returns>
        public static List<Book> GetGenreIsFantastic()
        {
            List<Book> fantastic = new();

            foreach (Book book in Book.Books)
                if (book.Genre == Genre.Fantastic) fantastic.Add(book);

            return fantastic;
        }

        /// <summary>
        /// Возвращает список с выданнами книгами
        /// </summary>
        /// <returns> список Book </returns>
        public static List<Book> GetStatusIsTake()
        {
            List<Book> bookIsTake = new();

            foreach (Book book in Book.Books)
                if (book.IsTake == true) bookIsTake.Add(book);

            return bookIsTake;
        }
    }
}