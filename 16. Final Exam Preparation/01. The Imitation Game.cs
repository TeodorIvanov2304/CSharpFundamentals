/*
During World War 2, you are a mathematician who joined the cryptography team to decipher the enemy's enigma code. Your job is to create a program to crack the codes. 
On the first line of the input, you will receive the encrypted message. After that, until the "Decode" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its true content. There are several types of instructions, split by '|'
•	"Move {number of letters}":
o	Moves the first n letters to the back of the string
•	"Insert {index} {value}":
o	Inserts the given value before the given index in the string
•	"ChangeAll {substring} {replacement}":
o	Changes all occurrences of the given substring with the replacement text
Input / Constraints
•	On the first line, you will receive a string with a message.
•	On the following lines, you will be receiving commands, split by '|' .
Output
•	After the "Decode" command is received, print this message:
"The decrypted message is: {message}"

*/
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