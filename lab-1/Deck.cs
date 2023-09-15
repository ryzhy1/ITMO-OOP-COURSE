using System;
using card;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deck
{
    public class Deck
    {
        public void PrintDeck(List<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }
}
