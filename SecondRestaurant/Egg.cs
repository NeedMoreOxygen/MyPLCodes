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
        int quality;
        public Egg(int quantity) : base(quantity)
        {
            quality = r.Next(76, 100);
        }
        public int GetQuality()
        {
            return quality;
        }
        public void Crack() { }
        public void DiscardShell() { }
        public void Cook() { }
    }
}