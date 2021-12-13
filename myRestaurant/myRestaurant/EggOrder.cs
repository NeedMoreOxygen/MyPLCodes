using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRestaurant
{
    class EggOrder
    {
        static Random r = new Random();
        int quantity = 0;
        public int? quality;
        public static int instances = 0;
        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            instances++;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public int? GetQuality()
        {
            quality = r.Next(1, 100);
            if(instances % 2 == 0 && instances != 0)
            {
                return null;
            }
            else
            {
                return quality;
            }
        }
        public void Crack()
        {
            if(quality < 25)
            {
                throw new Exception("Rotten");
            }
        }
        public void DiscardShell() { }
        public void Cook() { }
    }
}
