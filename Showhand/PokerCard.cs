using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class PokerCard
    {
        private Suit _suit;
        private Number _number;
        public PokerCard() { }
        public PokerCard(Suit suit, Number number)
        {
            _suit = suit;
            _number = number;
        }
        override
        public string ToString()
        {
            return _suit.ToString() + "," + _number.ToString();
        }
    }
    enum Suit { spade, heart, diamond, club }
    enum Number { ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }
}
