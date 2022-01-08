using System;
using System.Collections.Generic;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent produduct.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exeptional product.", "I can't live without this product." };
            string[] events = { "Now i feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now i feel awsome.", "Try it yourself, I am very satisfied.", "I feel great!" };
           string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            List<FakeMessage> messages = new List<FakeMessage>();
            Random randomIndex = new Random();
            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                FakeMessage message = new FakeMessage();
                message.Phrase = phrases[randomIndex.Next(0, phrases.Length)];
                message.Event = events[randomIndex.Next(0, events.Length)];
                message.Author = authors[randomIndex.Next(0, authors.Length)];
                message.City = cities[randomIndex.Next(0, cities.Length)];
                messages.Add(message);
            }

            foreach (FakeMessage message in messages)
            {
                Console.WriteLine($"{message.Phrase} {message.Event} {message.Author} - {message.City}");
            }
        }
    }
}
