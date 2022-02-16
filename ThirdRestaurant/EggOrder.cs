using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    class EggOrder
    {
        Random r = new Random();
        int quality;
        public int GetQuality()
        {
            return quality;
        }
        public void SetQuality(int quality)
        {
            this.quality = r.Next(75, 100);
        }
    }
}
