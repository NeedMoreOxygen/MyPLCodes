using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Chicken : Meal
    {
        public Chicken(int quantity) : base(quantity)
        {
            this.quantity = quantity;
        }
        public void CutUp() { }
        public override void PrepareFood() 
        {
            int n = GetQuantity();
            for (int i = 0; i <= n; i++)
            {
                CutUp();
            }
            Cook();
        }
    }
}