using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRestaurant
{
    class ChickenOrder
    {
        int quantity = 0;
        public static int instances = 0;
        public ChickenOrder(int quantity)
        {
            this.quantity = quantity;
            instances++;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public void CutUp() { }
        public void Cook() { }
    }
}
