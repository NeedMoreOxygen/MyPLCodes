using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Meal
    {
        protected int quantity = 0;
        public Meal(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public void Cook() { }
        virtual public void PrepareFood(){ }
        public void SubtractQuantity()
        {
            quantity--;
        }
    }
}
