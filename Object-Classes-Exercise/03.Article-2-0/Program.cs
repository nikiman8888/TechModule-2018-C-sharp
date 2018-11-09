using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03.Article_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var saveArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                var currentArticle = new Article(title, content, author);

                saveArticles.Add(currentArticle);
            }

            string command = Console.ReadLine();

            PrintResult(saveArticles, command);
        }

        private static void PrintResult(List<Article> saveArticles, string command)
        {
            switch(command)
            {
                case "title":
                    foreach (var current in saveArticles.OrderBy(x=>x.Title))
                    {
                        current.OverrideToString();
                    }
                    break;
                case "content":
                    foreach (var current in saveArticles.OrderBy(x => x.Content))
                    {
                        current.OverrideToString();
                    }
                    break;
                case "author":
                    foreach (var current in saveArticles.OrderBy(x => x.Author))
                    {
                        current.OverrideToString();
                    }
                    break;
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }      
        public void OverrideToString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}
