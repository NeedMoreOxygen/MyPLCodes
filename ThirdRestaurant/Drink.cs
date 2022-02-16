using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    abstract class Drink : IMenuItem
    {
        public void Obtain() { /* obtainig... */ }
        public void Serve() { /* serving... */ }
    }
}
