using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class ExchangeSuffle : ISuffle
    {
        public PokerCard[] Suffle(PokerCard[] pokerCards)
        {
            Random random = new Random();
            int times = random.Next(50, 200);
            PokerCard temp;

            for (int i = 0; i < times; i++) {
                var exchangecard1 = random.Next(0, 51);
                var exchangecard2 = random.Next(0, 51);
                temp = pokerCards[exchangecard1];
                pokerCards[exchangecard1] = pokerCards[exchangecard2];
                pokerCards[exchangecard2] = temp;
            }
            return pokerCards;
        }
    }
}
