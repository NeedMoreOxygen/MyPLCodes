﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    sealed class Cola : Drink, IMenuItem
    {
        public override void Obtain() { /* obtaining cola... */ }

        public override void Serve() { /* serving cola... */ }
    }
}
