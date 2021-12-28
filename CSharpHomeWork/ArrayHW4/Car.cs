using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW4
{
    class Car
    {
        string brand;
        string model;
        string carNumber;
        string driverName;
        string addition;
        public Car(string brand, string model, string carNumber, string driverName, string addition)
        {
            this.brand = brand;
            this.model = model;
            this.carNumber = carNumber;
            this.driverName = driverName;
            this.addition = addition;
        }
    }
}
