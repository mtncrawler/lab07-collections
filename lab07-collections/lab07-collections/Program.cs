using System;
using lab07_collections.classes;
using System.Collections.Generic;

namespace lab07_collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cards card1 = new Cards() { Suit = Suit.Hearts, Value = Value.Ace };
            Cards card2 = new Cards() { Suit = Suit.Diamonds, Value = Value.Jack };
            Cards card3 = new Cards() { Suit = Suit.Spades, Value = Value.Three };
            Cards card4 = new Cards() { Suit = Suit.Clubs, Value = Value.Queen };
            Cards card5 = new Cards() { Suit = Suit.Hearts, Value = Value.King };

            Deck<Cards> myDeck = new Deck<Cards>
            {
                card1,
                card2,
                card3,
                card4,
                card5
            };

            PrintDeck(myDeck);

            Console.WriteLine();
            
            PrintDeck(myDeck.ReturnSuit(Suit.Hearts));
        }

        /// <summary>
        /// print all cards in the deck
        /// </summary>
        /// <param name="deck"></param>
        public static void PrintDeck(Deck<Cards> deck)
        {
            foreach (Cards card in deck)
            {
                if (card != null)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }
        }
    }
}
