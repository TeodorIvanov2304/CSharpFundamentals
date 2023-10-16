using System.Collections.Generic;
using System;
using System.Security.Cryptography;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be given two hands of cards, which will be represented by integers.Assume each one is held by a different player.You have to find which one has the winning deck. You start from the beginning of both hands of cards. Compare the cards from the first deck to the cards from the second deck.The player, who holds the more powerful card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card is placed last and the first person's card(the winning one) comes after it(second to last).If both players' cards have the same values - no one wins and the two cards must be removed from both hands. The game is over only when
            //© SoftUni – about.softuni.bg.Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
            //Follow us: Page 4 of 7
            //one of the decks is left without any cards. You have to display the result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".

            List<int> playerOneCards = Console.ReadLine()
                                              .Split()
                                              .Select(int.Parse)
                                              .ToList();

            List<int> playerTwoCards = Console.ReadLine()
                                              .Split()
                                              .Select(int.Parse)
                                              .ToList();

            while (playerOneCards.Count>0 && playerTwoCards.Count>0) 
            {
                int playerOneCard  = playerOneCards[0];
                int playerTwoCard = playerTwoCards[0];
                //Player 1 wins
                if(playerOneCard>playerTwoCard) 
                {
                    int currentCard = playerOneCard;
                    playerOneCards.RemoveAt(0);
                    playerOneCards.Add(currentCard);
                    playerOneCards.Add(playerTwoCard);
                    playerTwoCards.RemoveAt(0);
                }
                //Player 2 wins
                else if(playerTwoCard>playerOneCard)
                {
                    int currentCard = playerTwoCard;
                    playerTwoCards.RemoveAt(0);
                    playerTwoCards.Add(currentCard);
                    playerTwoCards.Add(playerOneCard);
                    playerOneCards.RemoveAt(0);
                }
                //Draw
                else
                {
                    playerTwoCards.RemoveAt(0);
                    playerOneCards.RemoveAt(0);
                }
            }
            
            if (playerOneCards.Count>0) 
            {
                Console.WriteLine($"First player wins! Sum: {playerOneCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoCards.Sum()}");
            }

            
        }
    }
}