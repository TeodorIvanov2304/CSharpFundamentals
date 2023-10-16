namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                        .Split(" ")
                                        .ToList();
            
            numbers.Reverse();

            List<string> result = new List<string>();

            foreach (string number in numbers) 
            {
                string[] items = number.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numbersToAdd in items)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));


        }
    }
}