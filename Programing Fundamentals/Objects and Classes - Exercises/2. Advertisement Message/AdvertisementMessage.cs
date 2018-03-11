using System;

namespace _2._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            var events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int messages = int.Parse(Console.ReadLine());

            for (int i = 0; i < messages; i++)
            {
                Random rnd = new Random();
                int randomPhrase = rnd.Next(0, phrases.Length);
                int randomEvent = rnd.Next(0, events.Length);
                int randomAuthor = rnd.Next(0, authors.Length);
                int randomCity = rnd.Next(0, cities.Length);
                var phrase = phrases[randomPhrase];
                var even = events[randomEvent];
                var author = authors[randomAuthor];
                var city = cities[randomCity];

                Console.WriteLine($"{phrase} {even} {author} – {city}.");

            }



        }
    }
}
