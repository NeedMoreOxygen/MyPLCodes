using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    abstract class Drink : IMenuItem
    {
        public void Obtain() { /* obtaining... */ }
        public void Serve() { /* serving... */ }
    }
}
