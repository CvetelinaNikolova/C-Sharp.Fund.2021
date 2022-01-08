using System;
using System.Collections.Generic;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Article_List articleList = new Article_List();
            articleList.articles = new List<Article_properties>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                Article_properties artic = new Article_properties();
                string[] command = Console.ReadLine().Split(", ");
                artic.Title = command[0];
                artic.Content = command[1];
                artic.Author = command[2];
                articleList.articles.Add(artic);
            }

            Article_properties[] articleArr = articleList.articles.ToArray();

            string orderBy = Console.ReadLine();

            if (orderBy=="title")
            {
                Array.Sort(articleArr, OrderByTitle);
            }
            else if (orderBy=="content")
            {
                Array.Sort(articleArr, OrderByContetnt);
            }
            else if (orderBy=="author")
            {
                Array.Sort(articleArr, OrderByAuthor);
            }

            foreach (Article_properties article in articleArr)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
            
        }
        static int OrderByTitle(Article_properties title1, Article_properties title2)
        {
            return title1.Title.CompareTo(title2.Title);
        }
        static int OrderByContetnt(Article_properties content1, Article_properties content2)
        {
            return content1.Content.CompareTo(content2.Content);
        }
        static int OrderByAuthor(Article_properties author1, Article_properties author2)
        {
            return author1.Author.CompareTo(author2.Author);
        }

    }
}
