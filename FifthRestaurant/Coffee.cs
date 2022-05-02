using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    sealed class Coffee : Drink, IMenuItem
    {
        public override void Obtain() { /* obtaining coffee... */ }

        public override void Serve() { /* serving coffee... */ }
    }
}
