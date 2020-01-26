using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
                { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = 
                { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = 
                { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = 
                { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());

            Random randomNum = new Random();

            for (int i = 0; i < number; i++)
            {
                string phrase = phrases[randomNum.Next(0, phrases.Length)];
                string @event = events[randomNum.Next(0, events.Length)];
                string author = authors[randomNum.Next(0, authors.Length)];
                string city = cities[randomNum.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {@event} {author} - {city}");
            }
        }

    }
}
