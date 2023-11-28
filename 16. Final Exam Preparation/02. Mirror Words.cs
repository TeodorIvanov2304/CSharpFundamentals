/*
The SoftUni Spelling Bee competition is here. But it`s not like any other Spelling Bee competition out there. It`s different and a lot more fun! You, of course, are a participant, and you are eager to show the competition that you are the best, so go ahead, learn the rules and win!
On the first line of the input, you will be given a text string. To win the competition, you have to find all hidden word pairs, read them, and mark the ones that are mirror images of each other.
First of all, you have to extract the hidden word pairs. Hidden word pairs are:
•	Surrounded by "@" or "#" (only one of the two) in the following pattern #wordOne##wordTwo# or @wordOne@@wordTwo@
•	At least 3 characters long each (without the surrounding symbols).
•	Made up of letters only.
If the second word, spelled backward, is the same as the first word and vice versa (casing matters!), they are a match, and you have to store them somewhere. Examples of mirror words: 
#Part##traP# @leveL@@Level@ #sAw##wAs#
•	If you don`t find any valid pairs, print: "No word pairs found!"
•	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
•	If there are no mirror words, print: "No mirror words!"
•	If there are mirror words print:
"The mirror words are:
{wordOne} <=> {wordtwo}, {wordOne} <=> {wordtwo}, … {wordOne} <=> {wordtwo}"
Input / Constraints
•	You will recive a string.
Output
•	Print the proper output messages in the proper cases as described in the problem description.
•	If there are pairs of mirror words, print them in the end, each pair separated by ", ".
•	Each pair of mirror word must be printed with " <=> " between the words.

*/
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\@|\#]{1})(?<FirstWord>[A-Za-z]{3,})\1{2}(?<SecondWord>[A-Za-z]{3,})\1{1}";

            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count==0) 
            {
                Console.WriteLine($"No word pairs found!");
                Console.WriteLine($"No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            Dictionary<string,string> mirroredWords = new Dictionary<string,string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["FirstWord"].Value;
                string secondWord = match.Groups["SecondWord"].Value;
                string reversedSecond = "";
                reversedSecond = ReverseWord(secondWord, reversedSecond);
                string reversedFirst = "";
                reversedFirst = ReverseWord(firstWord, reversedFirst);

                if (firstWord == reversedSecond && secondWord == reversedFirst)
                {
                    mirroredWords.Add(firstWord, secondWord);
                }
            }

            if (mirroredWords.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var kvp in mirroredWords)
                {
                    stringBuilder.Append($"{kvp.Key} <=> {kvp.Value}, ");
                    //Console.Write($"{kvp.Key} <=> {kvp.Value}, ");
                }
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Length -= 2;
                }

                Console.WriteLine(stringBuilder.ToString());
            }
            
        }

        public static string ReverseWord(string word, string reversedWord)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return reversedWord;
        }
    }
}