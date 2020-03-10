using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    class Person
    {
        public Person() { pokerCards = new List<PokerCard>(); }
        public List<PokerCard> pokerCards { get; set;}
    }
}
