using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class FairDeal : IDeal
    {
        public Person[] Deal(Person[] people, PokerCard[] pokerCards){
            int playerNumber = people.Length;
            
            for (int i = 1; i <= 52; i++) {
                int whoscard = i % playerNumber;
                int cardno  = i / playerNumber;
                for(int j = 0; j < playerNumber; j++) { 
                    if (whoscard == j) { 
                        people[whoscard].pokerCards.Add(pokerCards[i-1]);
                        break;
                    } 
                }                
            }
            return people;
        }
    }
}
