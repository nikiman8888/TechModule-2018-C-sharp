using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var autors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var city = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random rd = new Random();
           
            for (int i = 0; i < count; i++)
            {
                string randomPrases = phrases[rd.Next(0, phrases.Count)];
                string randomEvents = events[rd.Next(0, events.Count)];
                string randomAutor = autors[rd.Next(0, autors.Count)];
                string randomCity = city[rd.Next(0, city.Count)];

                var currentMessage = new Message(randomPrases,randomEvents,randomAutor,randomCity);

                Console.WriteLine($"{currentMessage.Prases} {currentMessage.Events} {currentMessage.Autors} – {currentMessage.City}");
            }
        }
    }
    class Message
    {
        public string Prases { get; set; }
        public string Events { get; set; }
        public string Autors { get; set; }
        public string City { get; set; }

        public  Message(string prases,string events,string autor,string city)
        {
            this.Prases = prases;
            this.Events = events;
            this.Autors = autor;
            this.City = city;
        }
    }
}
