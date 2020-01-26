using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine()
            .Split(", ");

            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Article article = new Article(title, content, author);
            int countComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countComands; i++)
            {
                string[] commandArticles = Console.ReadLine().Split(": ");

                string command = commandArticles[0];

                if (command == "Edit")
                {
                    string currentContent = commandArticles[1];
                    article.Edit(currentContent);
                }
                else if (command == "ChangeAuthor ")
                {
                    string currentAuthor = commandArticles[1];
                    article.Change(currentAuthor);
                }
                else if (command == "Rename")
                {
                    string currentTitle = commandArticles[1];
                    article.Rename(currentTitle);
                }
            }
            Console.WriteLine(article);
        }
            class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public void Edit(string newContent)
            {
                this.Content = newContent;
            }
            public void Change(string newAuthor)
            {
                this.Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
