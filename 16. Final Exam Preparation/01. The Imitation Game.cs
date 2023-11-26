using System.Text;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string instructions = "";
            while ((instructions = Console.ReadLine()) != "Decode") 
            {
                string[] instuctionTokens = instructions.Split("|").ToArray();
                string instruction = instuctionTokens[0];
                
                switch (instruction) 
                {
                    case "Move":

                        int lettersToMove = int.Parse(instuctionTokens[1]);
                        string stringToRemove = encryptedMessage.Substring(0, lettersToMove);
                        encryptedMessage = encryptedMessage.Remove(0, lettersToMove);
                        encryptedMessage = encryptedMessage + stringToRemove;

                        break;
                    case "Insert":
                        int index = int.Parse(instuctionTokens[1]);
                        string value = instuctionTokens[2];
                        encryptedMessage = encryptedMessage.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = instuctionTokens[1];
                        string replacement = instuctionTokens[2];
                        if (encryptedMessage.Contains(substring))
                        {
                            encryptedMessage = encryptedMessage.Replace(substring, replacement);
                        }
                        
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}