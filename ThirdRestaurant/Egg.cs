using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    sealed class Egg : CookedFood, IMenuItem, IDisposable
    {
        public int quality;
        override public void Obtain() { /* obtainig an egg... */ }
        override public void Cook() { /* cooking an egg... */ }
        override public void Serve() { /* serving an egg... */ }
        public void Crack() {
            /* cracking */
            if (quality < 50)
                throw new Exception("Rotten Eggs");
        }
        public void DiscardShell() { /* discarding shell... */ }
        public void Dispose() { }
    }
}
