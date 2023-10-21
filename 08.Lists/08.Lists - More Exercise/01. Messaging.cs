namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string text = Console.ReadLine();
            
            string finalText = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                string sums = numbers[i].ToString();
                for (int j = 0; j < sums.Length; j++)
                {
                    int currentNumber = int.Parse(sums[j].ToString());
                    sum += currentNumber;
                }

                int index = sum;

                if(index>text.Length)
                {
                    index = index - text.Length;
                }

                finalText += text[index];
                text = text.Remove(index, 1);
                
            }
            Console.WriteLine(finalText);

        }
    }
}