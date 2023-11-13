namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfPersons; i++)
            {
              
                    string input = Console.ReadLine();
                    int startIndexName = input.IndexOf('@');
                    int endIndexName = input.IndexOf('|');
                    string name = input.Substring(startIndexName + 1, endIndexName - startIndexName - 1);
                    int startIndexAge = input.IndexOf('#');
                    int endIndexAge = input.IndexOf('*');
                    string ageStr = input.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);
                    Console.WriteLine($"{name} is {ageStr} years old.");

            
        }
    }
}