using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries) ;
            decimal totalSum  = 0 ;
            foreach (string item in items) 
            {
                char frontLetter = item[0];
                char backLetter = item[item.Length-1];

                decimal number = decimal.Parse(item.Substring(1, item.Length-2));
                decimal position;
                decimal result = 0;

                if (char.IsUpper(frontLetter))
                {   
                    //Position(0) = 65'A' - 'A'(65) + 1. Така намираме позицията на буквата в таблицата, в случая 1
                    position = frontLetter - 'A' + 1;
                    result = number / position;
                }
                else if(char.IsLower(frontLetter)) 
                {
                    position = frontLetter - 'a' + 1;
                    result = number * position;
                }

                if (char.IsUpper(backLetter))
                {
                    position = backLetter - 'A' + 1;
                    result -=  position;
                }
                else if (char.IsLower(backLetter))
                {
                    position = backLetter - 'a' + 1;
                    result +=  position;
                }

                totalSum += result ;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}