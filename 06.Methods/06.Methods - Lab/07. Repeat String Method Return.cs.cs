namespace _07._Repeat_String_Method_Return
{
    internal class RepeatStringMethodReturn
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(text, n);
            Console.WriteLine(result);
        }

        static string RepeatString(string text, int repeats)
        {
            string newText = "";
            for (int i = 0; i < repeats; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}