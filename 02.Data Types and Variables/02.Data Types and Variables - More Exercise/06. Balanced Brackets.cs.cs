namespace _06._Balanced_Brackets
{
    internal class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingB = 0;
            int closingB = 0;
            string lastString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string nextString = Console.ReadLine();
                lastString = nextString;
                if (nextString == "(")
                {
                    openingB++;
                    lastString = nextString;
                }
                else if (nextString == ")")
                {
                    closingB++;
                    lastString = nextString;
                }
            }
            // Ако string-ът завършва с отворена скоба "(", има възможност скобите да са еднакъв брой но пак да даде грешка, защото скобите ще са обратни 
            if (openingB == closingB&&lastString!="(")
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}