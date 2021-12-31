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
        public string Register(string brand, string model, string licensePlate, string driverName, string addition)
        {
            switch (brand)
            {
                case "Mercedes-Benz":
                    newCar = new MercedesBenz(brand, model, licensePlate, driverName, addition);
                    break;
                case "Opel":
                    newCar = new Opel(brand, model, licensePlate, driverName, addition);
                    break;
                case "Lada":
                    newCar = new Lada(brand, model, licensePlate, driverName, addition);
                    break;
                default:
                    newCar = new Car(brand, model, licensePlate, driverName, addition);
                    break;
            }
            Array.Resize<Car>(ref newCars, newCars.Length + 1);
            newCars[newCars.Length - 1] = newCar;
            return $"{driverName} - {brand} - {model} - {licensePlate}{addition}\n";
        }
        public string Drive()
        {
            string s = "";
            for (int i = 0; i < newCars.Length; i++)
            {
                switch (newCars[i].GetBrand())
                {
                    case "Mercedes-Benz":
                        s += $"{i+1}) {((MercedesBenz)newCars[i]).Go()}\n";
                        break;
                    case "Opel":
                        s += $"{i + 1}) {((Opel)newCars[i]).Go()}\n";
                        break;
                    case "Lada":
                        s += $"{i + 1}) {((Lada)newCars[i]).Go()}\n";
                        break;
                    default:
                        s += $"{i + 1}) {newCars[i].Go()}\n";
                        break;
                }

            }
            return s;
        }
    }
}
