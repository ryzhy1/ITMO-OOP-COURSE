using System;
using card;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    internal class Cards
    {
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }

        private List<Card> CreateCards()
        {

            List<Card> deck = new List<Card>();

            var CardList = from s in Suits()
                           from r in Ranks()
                           select new Card(s, r);

            foreach (var card in CardList)
            {
                deck.Add(card);
            }

            return deck;
        }

        public void PrintCards()
        {
            var deck = CreateCards();

            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }
}
