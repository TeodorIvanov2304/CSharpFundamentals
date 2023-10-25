namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = data[0];
                string content = data[1];
                string author = data[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            foreach (Article article in articles) 
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        
    }
}