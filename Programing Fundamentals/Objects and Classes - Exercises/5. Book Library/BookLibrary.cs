using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _5._Book_Library
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var library = new Library();
            library.Books = new List<Book>();
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

                library.Books.Add(book);
            }

            //total sum of prices by author, ordered descending by price and 
            //then by author’s name lexicographically.
            var sorted = library.Books.GroupBy(b => b.Author).Select(b => new { Author = b.Key, Prices = b.Sum(p => p.Price)}).OrderByDescending(b => b.Prices).ThenBy(b => b.Author);
            Console.WriteLine(string.Join(Environment.NewLine, sorted.Select(a => $"{a.Author} -> {a.Prices:F2}")));

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

    class Library
    {
        public List<Book> Books { get; set; }
        public string Name { get; set; }
    }
}
