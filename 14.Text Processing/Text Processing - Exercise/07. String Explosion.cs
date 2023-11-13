using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = ProcessExplosions(input);
            Console.WriteLine(result);

        }

        public static string ProcessExplosions(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();
            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {   
                //Ако input[i] == > , добавяме го и парсваме strength 
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    resultBuilder.Append(input[i]);
                }
                // Ако strength == 0, добавяме елементите от input към StringBuilder
                else if(strength == 0)
                {
                    resultBuilder.Append(input[i]);
                }
                //Ако strength != 0 не слагаме елементи, а намаляваме strength, за да ги скипнем
                else
                {
                    strength--;
                }
            }



            return resultBuilder.ToString();
        }
    }
}