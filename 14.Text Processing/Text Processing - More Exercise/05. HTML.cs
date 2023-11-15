namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleAndArticle = Console.ReadLine();


            string content = Console.ReadLine();
            string comment = "";
            List<string> comments = new List<string>();

            while ((comment = Console.ReadLine()) != "end of comments")
            {

                comments.Add(comment);
            }
            PrintTitle(titleAndArticle);
            PrintContent(content);
            PrintComments(comments);
        }

        public static void PrintComments(List<string> comments)
        {
            foreach (string comment in comments) 
            {
                Console.WriteLine($"<div>\n    {comment}\n</div>");
            }
        }

        private static void PrintContent(string content)
        {
            Console.WriteLine($"<article>\n    {content}\n</article>");
        }

        public static void PrintTitle(string title)
        {
            Console.WriteLine($"<h1>\n    {title}\n</h1>");
        }
    }
}

