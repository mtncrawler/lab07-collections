using System;
using lab07_collections.classes;
using System.Collections.Generic;

namespace lab07_collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Your current hand=====");
            Console.WriteLine();

            Cards card1 = new Cards() { Suit = Suit.Hearts, Value = Value.Ace };
            Cards card2 = new Cards() { Suit = Suit.Diamonds, Value = Value.Jack };
            Cards card3 = new Cards() { Suit = Suit.Spades, Value = Value.Three };
            Cards card4 = new Cards() { Suit = Suit.Clubs, Value = Value.Queen };
            Cards card5 = new Cards() { Suit = Suit.Hearts, Value = Value.King };
            Cards card6 = new Cards() { Suit = Suit.Hearts, Value = Value.Nine };
            Cards card7 = new Cards() { Suit = Suit.Diamonds, Value = Value.Five };
            Cards card8 = new Cards() { Suit = Suit.Spades, Value = Value.Two };
            Cards card9 = new Cards() { Suit = Suit.Clubs, Value = Value.Three };
            Cards card10 = new Cards() { Suit = Suit.Hearts, Value = Value.Queen };

            Deck<Cards> myDeck = new Deck<Cards>
            {
                card1, card2, card3, card4, card5, card6, card7, card8, card9, card10
            };

            PrintDeck(myDeck);
            Console.WriteLine();

            Console.WriteLine("=====ADD Two of Spades=====");
            Console.WriteLine();

            Cards card11 = new Cards() { Suit = Suit.Spades, Value = Value.Two };
            myDeck.Add(card11);
            PrintDeck(myDeck);
            Console.WriteLine();

            Console.WriteLine("=====REMOVE Queen of Hearts=====");
            myDeck.Remove(card10);
            PrintDeck(myDeck);
            Console.WriteLine();

            Console.WriteLine("=====SUITS Clubs======");
            PrintDeck(myDeck.ReturnSuit(Suit.Clubs));
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
