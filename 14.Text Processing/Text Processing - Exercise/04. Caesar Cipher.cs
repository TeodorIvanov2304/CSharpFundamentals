using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string text = Console.ReadLine();
            //Създаваме нова променлива тип StringBuilder
            StringBuilder encryptedText = new StringBuilder();
            //Пускаме цикъл, който върти по дължината на променливата text
            for (int i = 0; i < text.Length; i++)
            {   
                //Създаваме променлива, която пази текущия символ
                char currentChar = text[i];
                //Създаваме променлива, която пази криптирания символ, 3 букви напред от текущия
                char encryptedChar = (char)(currentChar + 3);
                //Добавяме към StringBuilder-a
                encryptedText.Append(encryptedChar.ToString());
            }
            Console.WriteLine(encryptedText);
        }
    }
}