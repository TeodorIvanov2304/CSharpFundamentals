namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();

            foreach (string username in usernames)
            {


                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                if (isValidUserName(username))
                {
                    Console.WriteLine(username);
                }
            }

        }

        //Създаваме bool метод
        public static bool isValidUserName(string username)
        {
            return username.All(ch => char.IsLetterOrDigit(ch)
                                                      || ch == '_'
                                                      || ch == '-');
        }
    }
}