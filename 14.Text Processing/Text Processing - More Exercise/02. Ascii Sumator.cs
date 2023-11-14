namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char start = char.Parse(Console.ReadLine());
            char end  = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (currentSymbol > start && currentSymbol < end)
                {
                    sum += (int)currentSymbol;
                }
            }
            Console.WriteLine(sum);

        }
    }
}