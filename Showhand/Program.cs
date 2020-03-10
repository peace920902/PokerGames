using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Person[] people = new Person[4] ;
            for (int i = 0; i < people.Length; i++) {
                people[i] = new Person();
            }
            PokerCard[] pokerCards = card.CreateNewPorkerCard();
            ISuffle _suffle;
            IDeal _deal;
            _suffle = new ExchangeSuffle();
            _deal = new FairDeal();
            pokerCards = _suffle.Suffle(pokerCards);

            people = _deal.Deal(people,pokerCards);
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("第{0}個人的牌為", i + 1);
                foreach (var j in people[i].pokerCards)
                {
                    Console.WriteLine(j + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
