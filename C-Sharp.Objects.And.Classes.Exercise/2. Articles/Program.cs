using System;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            string[] properties = Console.ReadLine().Split(", ");

            article.Title = properties[0];
            article.Content = properties[1];
            article.Author = properties[2];

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string[] input = new string[command.Length - 1];
                for (int j = 0; j < input.Length; j++)
                {
                    int p = j + 1;
                    input[j] = command[p];
                }
                string finalInput = String.Join(" ", input);
                switch (command[0])
                {
                    case "Edit:":
                        article.Edit(finalInput);
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(finalInput);
                        break;
                    case "Rename:":
                        article.Rename(finalInput);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
