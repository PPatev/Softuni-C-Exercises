using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6._Book_Library_Modification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var title = input[0];
                var author = input[1];
                var publisher = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = input[4];
                var price = double.Parse(input[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    IsbnNumber = isbn,
                    Price = price
                };

                books.Add(book);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            /*Use the classes from the previous problem and 
             * make a program that read a list of books and 
             * print all titles released after given date 
             * ordered by date and then by title lexicographically. 
             * The date is given in the format “dd.MM.yyyy” at the last line in the input.*/
            var filtered = books.Where(b => b.ReleaseDate > date).OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title);

            Console.WriteLine(string.Join(Environment.NewLine, filtered.Select(b => $"{b.Title} -> {b.ReleaseDate.Day:D2}.{b.ReleaseDate.Month:D2}.{b.ReleaseDate.Year}")));
        }
    }

    class Book
    {
        /*the title, author, publisher, release date (in dd.MM.yyyy format),
         * ISBN-number and price. */
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IsbnNumber { get; set; }
        public double Price { get; set; }
    }
}
