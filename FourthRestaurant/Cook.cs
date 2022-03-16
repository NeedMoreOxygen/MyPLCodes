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
            var chickenRequest = table.Get<Chicken>();
            foreach (Chicken chicken in chickenRequest)
            {
                chicken.Obtain();
                chicken.CutUp();
                chicken.Cook();
            }

            var eggRequest = table.Get<Egg>();
            foreach (Egg egg in eggRequest)
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
