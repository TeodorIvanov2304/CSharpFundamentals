using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace _09._Kamino_Factory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            //The clone factory in Kamino got another order to clone troops.But this time you are tasked to find the best DNA sequence to use in the production. 
            //You will receive the DNA length and until you receive the command "Clone them!", you will be receiving a DNA sequence of ones and zeroes, split by '!'(one or several).
            //You should select the sequence with the longest subsequence of ones.If there are several sequences with the same length of the subsequence of ones, print the one with the leftmost starting index, if there are several sequences with the same length and starting index, select the sequence with the greater sum of its elements.
            //After you receive the last command "Clone them!" you should print the collected information in the following format:
            // "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
            //"{DNA sequence, joined by space}"

            int size = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int bestCount = 0;
            int counter = 0;
            int bestBeginIndex = 0;
            int bestSum = 0;
            int bestCounter = 0;
            string bestSequence = string.Empty;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0",StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string bestSubSequence = string.Empty;
                counter++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length>count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum+= dnaPart.Length;
                }

                int beginIndex = sequence.IndexOf(bestSubSequence);

                if(count>bestCount || (count == bestCount && beginIndex < bestBeginIndex)
                                   || (count == bestCount &&beginIndex == bestBeginIndex && sum>bestSum)
                                   || counter == 1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;

                }
            }
            char[] result = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}