namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = new string(new char[] { 'a', 'b', 'c' });

            for (int i = 0; i < 100; i++)
            {
                name += name;
                Console.WriteLine(i);
            }
            
        }
    }
}