using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Dealer
    {
        public Dealer() { }

        public string[] ShuffleCards(string[] cards)
        {
            Random rnd = new Random();

            var half = cards.Length / 2;
            string[] shaffledCards = { };

            for (int i = 0; i < half; i++)
            {
                shaffledCards[i*2] = cards[i + half];
                shaffledCards[i*2+1] = cards[i];
            }

            return shaffledCards;
        }
    }
}
