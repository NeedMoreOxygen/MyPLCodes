using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW4
{
    class Car
    {
        protected string brand;
        protected string model;
        protected string carNumber;
        protected string driverName;
        protected string addition;
        public Car(string brand, string model, string carNumber, string driverName, string addition)
        {
            this.brand = brand;
            this.model = model;
            this.carNumber = carNumber;
            this.driverName = driverName;
            this.addition = addition;
        }
        public void DriveToB() { }
        public void NextLoop() { }
        public void DriveToA() { }

        public string Go()
        {
            string s = "";
            DriveToB();
            s += $"Машина доехала из пункта A в пункт B";
            return s;
        }
        public string GetBrand()
        {
            return brand;
        }
    }
}
