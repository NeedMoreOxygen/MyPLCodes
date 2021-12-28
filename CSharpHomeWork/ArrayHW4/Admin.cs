using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW4
{
    class Admin
    {
        Car newCar;
        public Car[] newCars = new Car[0];
        public void Register(string brand, string model, string licensePlate, string driverName, string addition)
        {
            newCar = new Car(brand, model, licensePlate, driverName, addition);
            Array.Resize<Car>(ref newCars, newCars.Length + 1);
            newCars[newCars.Length - 1] = newCar;
        }
        public void DriveToDushanbe() { }
        public void NextLoop() { }
        public void DriveToKhujand() { }
    }
}
