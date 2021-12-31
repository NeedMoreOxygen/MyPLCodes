using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW4
{
    class Opel : Car
    {
        public Opel(string brand, string model, string carNumber, string driverName, string addition) : base(brand, model, carNumber, driverName, addition)
        {

        }
        new public string Go()
        {
            string s = "";
            DriveToB();
            s += $"Машина доехала из пункта A в пункт B\n";
            for (int i = 1; i <= 3; i++)
            {
                NextLoop();
                s += $"Машина проехала {i}-ый круг\n";
            }
            DriveToA();
            s += $"Машина доехала из пункта B в пункт A\n";
            return s;
        }
    }
}
