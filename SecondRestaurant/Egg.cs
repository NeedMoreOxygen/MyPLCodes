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
        int quality = r.Next(76, 100);
        public Egg(int quantity) : base(quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuality()
        {
            return quality;
        }
        public void DiscardShell() { }
        public void Cook() { }
    }
}