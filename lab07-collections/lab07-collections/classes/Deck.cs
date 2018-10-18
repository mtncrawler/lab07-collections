using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections.classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int count = 0;

        /// <summary>
        /// add a card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            
            cards[count++] = card;
        }

        /// <summary>
        /// remove a card from the deck
        /// </summary>
        /// <param name="card"></param>
        public void Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (cards[i].Equals(card))
                {
                    cards.SetValue(null, i);
                    break;
                }
            }
        }

        /// <summary>
        /// find all cards with the specified suit
        /// </summary>
        /// <param name="suit"></param>
        /// <returns>cards with the specified suit</returns>
        public Deck<Cards> ReturnSuit(Suit suit)
        {
            Deck<Cards> deck = new Deck<Cards>();

            for (int i = 0; i < count; i++)
            {
                Cards card = (Cards)Convert.ChangeType(cards[i], typeof(Cards));

                if (card != null && card.Suit == suit)
                {
                    deck.Add(card);
                }
            }
            return deck;
            
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
