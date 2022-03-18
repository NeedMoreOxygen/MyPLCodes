using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    class Cook
    {
        public delegate void OrderProcessed();
        public OrderProcessed Processed;
        public void Process(TableRequests table)
        {
            var chickenList = table.Get<Chicken>();
            foreach (Chicken chicken in chickenList)
            {
                chicken.Obtain();
                chicken.CutUp();
                chicken.Cook();
            }

            var eggList = table.Get<Egg>();
            foreach (Egg egg in eggList)
            {
                egg.Obtain();
                egg.Crack();
                egg.DiscardShell();
                egg.Cook();
            }
            Processed?.Invoke();
        }
    }
}
