using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    abstract class Drink : IMenuItem
    {
        abstract public void Obtain();
        abstract public void Serve();
    }
}
