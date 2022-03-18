using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    sealed class Egg : CookedFood, IMenuItem, IDisposable
    {
        override public void Obtain() { /* obtainig an egg... */ }
        override public void Cook() { /* cooking an egg... */ }
        override public void Serve() { /* serving an egg... */ }
        public void Crack() { /* cracking... */ }
        public void DiscardShell() { /* discarding shell... */ }
        public void Dispose() { }
    }
}
