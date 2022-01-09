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
        public void Submit(int quantity, string menuItem)
        {
            if (menuItem == "Chicken")
                chicken = new Chicken(quantity);
            else
                egg = new Egg(quantity);
        }
        public void PrepareFood(string menuItem)
        {
            if(menuItem == "Chicken")
            {
                for (int i = 0; i < chicken.GetQuantity(); i++)
                    chicken.CutUp();
                chicken.Cook();
            }
            else
            {
                for (int i = 0; i < egg.GetQuantity(); i++)
                {
                    egg.DiscardShell();
                }
                quality = egg.GetQuality();
                egg.Cook();
            }
        }
        public int GetQuality()
        {
            return quality;
        }
    }
}