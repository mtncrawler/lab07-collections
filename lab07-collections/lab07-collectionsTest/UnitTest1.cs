using lab07_collections.classes;
using System;
using Xunit;

namespace lab07_collectionsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test that a card is added to a deck
        /// </summary>
        [Fact]
        public void CardIsAdded()
        {
            Cards card1 = new Cards() { Suit = Suit.Hearts, Value = Value.Ace };
            Deck<Cards> myDeck = new Deck<Cards>();
            myDeck.Add(card1);
            
            Assert.Equal(1, myDeck.count);
        }

        /// <summary>
        /// test that an existing card is removed
        /// </summary>
        [Fact]
        public void ExistingCardIsRemoved()
        {
            Cards card1 = new Cards() { Suit = Suit.Hearts, Value = Value.Ace };
            Cards card2 = new Cards() { Suit = Suit.Diamonds, Value = Value.Jack };
         
            Deck<Cards> myDeck = new Deck<Cards>
            {
                card1, card2
            };

            myDeck.Remove(card2);
            int counter = 0;
            foreach (Cards item in myDeck)
            {
                if (item != null)
                {
                    counter++;
                }
            }
            
            Assert.Equal(1, counter);
        }

        /// <summary>
        /// test that an non-existing card is attempted to be removed
        /// </summary>
        [Fact]
        public void NonExistingCardIsRemoved()
        {
            Cards card1 = new Cards() { Suit = Suit.Hearts, Value = Value.Ace };
            Cards card2 = new Cards() { Suit = Suit.Diamonds, Value = Value.Jack };

            Deck<Cards> myDeck = new Deck<Cards> { card1 };
           
            myDeck.Remove(card2);

            Assert.Equal(1, myDeck.count);
        }

        /// <summary>
        /// tests that a card property of suit or value can be added
        /// </summary>
        [Fact]
        public void SetCardSuit()
        {
            Cards card1 = new Cards() { Suit = Suit.Diamonds, Value = Value.Ace };

            Assert.Equal(Suit.Diamonds, card1.Suit);
        }

        [Fact]
        public void SetCardValue()
        {
            Cards card1 = new Cards() { Suit = Suit.Diamonds, Value = Value.Ace };

            Assert.Equal(Value.Ace, card1.Value);
        }
    }
}
