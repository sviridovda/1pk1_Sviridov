using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task_21_03
{
    /*
         * создайте класс Book и сгенерируйте список объектов книг (минимум 100 элементов). проанализируйте список и выведите:
            книгу с самым ранним годом издания (если их несколько то все)
            книгу с самым поздним годом издания (если их несколько то все)
            только книги в жанре «фантастика»
            только книги в состоянии «выданы на руки»
         */

    enum Genre
    {
        Fantastic,
        Science,
        Encyclopedia
    }

    class Book
    {
        public string Title { get; private set; }           // название
        public Genre Genre { get; private set; }           // жанр
        public int YearOfPublication { get; private set; }  // год публикации
        public bool IsTake { get; private set; } = false;   // отдата ли книга

        public static List<Book> Books { get; private set; } = new();

        Dictionary<Genre, string> dictGenre = new Dictionary<Genre, string>()
        {
            [Genre.Fantastic] = "Фантастика",
            [Genre.Science] = "Наука",
            [Genre.Encyclopedia] = "Энциклопедия"
        };



        public Book(string title, Genre genre, int yearOfPublication)
        {
            Title = title;
            Genre = genre;
            YearOfPublication = yearOfPublication;

            Books.Add(this);
        }

        /// <summary>
        /// выдача книги
        /// </summary>
        public void BookTake()
        {
            if (!IsTake) IsTake = true;
        }

        /// <summary>
        /// возврат книги
        /// </summary>
        public void BookReturn()
        {
            if (IsTake) IsTake = false;
        }

        /// <summary>
        /// Вывод в консоль значений полей экземпляра книги
        /// </summary>
        public void PrintBook()
        {
            string status = IsTake == true ? "Выдана на руки" : "В архиве";
            Console.WriteLine(
                $"\nНазвание: {Title}; " +
                $"\nЖанр: {dictGenre[Genre]}; " +
                $"\nГод издания: {YearOfPublication}; " +
                $"\nСостояние: {status}"
                );
        }
    }
}