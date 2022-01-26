using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Cook
    {
        public Meal Submit(int quantity, string menuItem)
        {
            if (menuItem == "Chicken")
            {
                Chicken chicken = new Chicken(quantity);
                return chicken;
            }
            else
            {
                Egg egg = new Egg(quantity);
                return egg;
            }
        }
        public void PrepareFood(Meal order)
        {
            order.PrepareFood();
        }
    }
}