using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Cook
    {
        Chicken chicken;
        Egg egg;
        int quality;
        public Meal Submit(int quantity, string menuItem)
        {
            if (menuItem == "Chicken")
            {
                chicken = new Chicken(quantity);
                return chicken;
            }
            else
            {
                egg = new Egg(quantity);
                quality = egg.GetQuality();
                return egg;
            }
        }
        public void PrepareFood(Meal order)
        {
            if (order is Chicken)
            {
                for (int i = 0; i < chicken.GetQuantity(); i++)
                    chicken.CutUp();
                chicken.Cook();
            }
            else
            {
                for (int i = 0; i < egg.GetQuantity(); i++)
                {
                    egg.Crack();
                    egg.DiscardShell();
                }
                egg.Cook();
            }
        }
        public int GetQuality()
        {
            return quality;
        }
    }
}