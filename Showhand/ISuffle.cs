using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showhand
{
    interface ISuffle
    {
        PokerCard[] Suffle(PokerCard[] pokerCards); 
    }
}
