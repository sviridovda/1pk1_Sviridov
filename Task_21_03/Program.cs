using System.Security.Cryptography.X509Certificates;

namespace Task_21_03
{
    internal class Program
    {
        /*
         * создайте класс Book и сгенерируйте список объектов книг (минимум 100 элементов). проанализируйте список и выведите:
            книгу с самым ранним годом издания (если их несколько то все)
            книгу с самым поздним годом издания (если их несколько то все)
            только книги в жанре «фантастика»
            только книги в состоянии «выданы на руки»
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // массив названий книг
            string[] titles =
            {
                "История России", "Фантастические приключения",
                "Основы программирования C#", "География России", "Физика 10 класс"
            };

            // словарь названий книг и их жанров
            Dictionary<string, Genre> genres = new Dictionary<string, Genre>()
            {
                ["История России"] = Genre.Science,
                ["Фантастические приключения"] = Genre.Fantastic,
                ["Основы программирования C#"] = Genre.Science,
                ["География России"] = Genre.Encyclopedia,
                ["Физика 10 класс"] = Genre.Science
            };



            Console.Write("Введите кол-во книг (более 100) >> ");
            int countBooks;
            int.TryParse(Console.ReadLine(), out countBooks);

            // создание объекта книг
            for (int i = 0; i < countBooks; i++)
            {
                int ind = rnd.Next(0, titles.Length);
                string title = titles[ind];     // название
                Genre genre = genres[title];    // жанр

                int yearOfPublication = rnd.Next(0, DateTime.Now.Year + 1); // год издания

                Book book = new Book(title, genre, yearOfPublication);
                if (rnd.Next(0, 10) <= 7)                               // 70% шанс взятия книги
                {
                    book.BookTake();
                    if (rnd.Next(0, 2) == 0) book.BookReturn();         // 50% шанс возврата книги
                }
            }
            Console.Clear();


            // Книги с ранним изданием
            List<Book> minYearOfPublication = Filter.GetMinYearOfPublication();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Книги с самым ранним годом издания:");

            for (int i = 0; i < minYearOfPublication.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.DarkCyan;
                else Console.ForegroundColor = ConsoleColor.Cyan;

                // вывод информации о книге
                Console.Write($"Книга {i + 1}");
                minYearOfPublication[i].PrintBook();
            }

            // книги с поздним изданием
            List<Book> maxYearOfPublication = Filter.GetMaxYearOfPublication();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nКниги с самым поздним годом издания:");

            for (int i = 0; i < maxYearOfPublication.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.Gray;

                // вывод информации о книге
                Console.Write($"Книга {i + 1}");
                maxYearOfPublication[i].PrintBook();
            }

            // книги жанра фантастика
            List<Book> fantastic = Filter.GetGenreIsFantastic();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nКниги жанра фантастика:");

            for (int i = 0; i < fantastic.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.DarkCyan;
                else Console.ForegroundColor = ConsoleColor.Cyan;

                // вывод информации о книге
                Console.Write($"Книга {i + 1}");
                fantastic[i].PrintBook();
            }

            // книги выданные в руки
            List<Book> bookIsTake = Filter.GetStatusIsTake();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nКниги выданные на руки:");

            for (int i = 0; i < bookIsTake.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.Gray;

                // вывод информации о книге
                Console.Write($"Книга {i + 1}");
                bookIsTake[i].PrintBook();
            }

        }
    }
}