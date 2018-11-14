using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<h1>");

            string article = Console.ReadLine();
            Console.WriteLine(article);

            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");

            string articleDescription = Console.ReadLine();
            Console.WriteLine(articleDescription);

            Console.WriteLine("</article>");

            string coment = Console.ReadLine();

            while (coment != "end of comments")
            {

                Console.WriteLine("<div>");
                Console.WriteLine(coment);
                Console.WriteLine("</div>");

                coment = Console.ReadLine();
            }
        }
    }
}
