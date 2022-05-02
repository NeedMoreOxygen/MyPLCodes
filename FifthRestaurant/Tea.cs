using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    sealed class Tea : Drink, IMenuItem
    {
        public override void Obtain() { /* obtaining tea... */ }

        public override void Serve() { /* serving tea... */ }
    }
}
