using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class Card
    {
        private PokerCard[] pokerCards = new PokerCard[52];
        public PokerCard[] CreateNewPorkerCard() {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pokerCards[i * 13 + j] = new PokerCard((Suit)i, (Number)(j + 1));
                }
            }
            return pokerCards;
        }
    }
}
