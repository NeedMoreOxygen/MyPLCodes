using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    sealed class Chicken : CookedFood, IMenuItem
    {
        override public void Obtain() { /* obtainig a chicken... */ }
        override public void Cook() { /* cooking a chicken... */ }
        override public void Serve() { /* serving a chicken... */ }
        public void CutUp() { /* cutting... */ }
    }
}
