using System;


namespace _05._Decrypting_Message
{
    internal class DecryptingMessage
    {
        static void Main(string[] args)
        {
            //You will receive a key(integer) and n characters afterward. Add the key to each of the characters and append them to a message. At the end print the message, which you decrypted.
            //Input
            //• On the first line, you will receive the key.
            //• On the second line, you will receive n – the number of lines, which will follow.
            //• On the next n lines, you will receive lower and uppercase characters from the Latin alphabet.
            //Output
            //Print the decrypted message.
            //Constraints
            //• The key will be in the interval[0…20].
            //• n will be in the interval[1…20].
            //• The characters will always be upper or lower-case letters from the English alphabet.
            //• You will receive one letter per line.

            // Четем ключа от конзолата
            byte key = byte.Parse(Console.ReadLine());

            //Четем колко символа ще има n
            byte n = byte.Parse(Console.ReadLine());
            //Създаваме променлива в която ще пазим готовата дума
            string output = string.Empty;
            //Създаваме цикъл, който върти докато въведем n символа
            for (byte i = 0; i < n; i++)
            {
                // Четем символи от конзолата
                char letter = char.Parse(Console.ReadLine());
                // Създаваме нова променлива, в която пазим символа + ключа
                char keyLetter = (char)(letter + key); 
                // Добавяме символа който отговаря на ключа към готовата дума
                output += keyLetter;
            }
            //Изпечатваме на конзолата
            Console.Write(output);
        }
    }
}