using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FourthRestaurant
{
    class Cook
    {
        public bool busy;
        public void Process(TableRequests table)
        {
            var chickenList = table.Get<Chicken>();
            foreach (Chicken chicken in chickenList)
            {
                chicken.Obtain();
                chicken.CutUp();
            }

            var eggList = table.Get<Egg>();
            foreach (Egg egg in eggList)
            {
                egg.Obtain();
                egg.Crack();
                egg.DiscardShell();
                egg.Cook();
            }
        }
    }
}
