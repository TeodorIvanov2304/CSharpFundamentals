namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //Създаваме нов обект, и директно му приписваме стойностите на инпута
            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                                          .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string command = commands[0];
                string argument = commands[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        //Това е специален метод, с който override-ваме обекта, за да се изпечата като стринг
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}