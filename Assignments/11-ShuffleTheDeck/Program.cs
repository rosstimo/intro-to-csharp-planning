// This program simulates dealing cards from a shuffled deck.
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool[,] dealtCards = new bool[4, 13];
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Press Enter to deal a card or type 'shuffle' to shuffle the deck.");
            string input = Console.ReadLine();

            if (input.ToLower() == "shuffle")
            {
                dealtCards = new bool[4, 13];
                Console.WriteLine("Deck shuffled.");
                continue;
            }

            int suit, value;
            do
            {
                suit = random.Next(4);
                value = random.Next(13);
            } while (dealtCards[suit, value]);

            dealtCards[suit, value] = true;
            Console.WriteLine($"You drew the {values[value]} of {suits[suit]}.");

            if (AllCardsDealt(dealtCards))
            {
                Console.WriteLine("All cards have been dealt. Shuffling the deck.");
                dealtCards = new bool[4, 13];
            }
        }
    }

    static bool AllCardsDealt(bool[,] dealtCards)
    {
        foreach (bool dealt in dealtCards)
        {
            if (!dealt) return false;
        }
        return true;
    }
}
