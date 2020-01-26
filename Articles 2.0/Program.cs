using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var articles = new List<Articless>();

            string input = string.Empty;

          
            for (int i = 0; i < number; i++)
            {
                 input = Console.ReadLine();
                string[] splitedInput = input.Split(",");
                string title = splitedInput[0];
                string content = splitedInput[1];
                string author = splitedInput[2];

                var currentArticle = new Articless(title, content, author);

                articles.Add(currentArticle);
            }

            string orderBy = Console.ReadLine();

            if (orderBy=="title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy=="content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy=="author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine,articles));
        }
        
    }
}
