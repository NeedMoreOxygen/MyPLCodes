using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Egg : Meal
    {
        static Random r = new Random();
        public Egg(int quantity) : base(quantity)
        {
            this.quantity = quantity;
        }
        public void Crack() { }
        public void DiscardShell() { }
        override public void PrepareFood()
        {
            int n = GetQuantity();
            for(int i = 0; i <= n; i++)
            {
                Crack();
                DiscardShell();
            }
            Cook();
        }
    }
}