﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public Card(string Suit, string Rank) {
            this.Suit = Suit;
            this.Rank = Rank;
        }
    }
}
